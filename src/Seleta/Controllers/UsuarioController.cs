using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;
using Seleta.ViewModel;
using System.Security.Claims;

namespace Seleta.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        /**
         * Propriedade da classe para salvar o cpf do usuario
         * Não foi inicializado ainda, só declarado, a gente passa um valor pra ele no método do perfil
         * Ele é estático pra sempre que usuario mudar ele mudar também e não ocupar muita memoria
         */
        private static string? usuarioCpf;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login(CadastroUsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var dadosUsuario = await _context.Usuarios.FirstOrDefaultAsync(usuarioBanco => usuarioBanco.Email == usuario.Email);

                if (dadosUsuario == null)
                {
                    ViewBag.Message = "Email e/ou senha invalidos!";
                }

                bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dadosUsuario.Senha);

                if (senhaOk)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, dadosUsuario.Email),
                        new Claim(ClaimTypes.NameIdentifier, dadosUsuario.CPF.ToString())
                    };

                    var usuarioIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(usuarioIdentity);

                    var props = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                        IsPersistent = true
                    };

                    await HttpContext.SignInAsync(claimsPrincipal, props);

                    return RedirectToAction(nameof(Perfil));
                }
                else
                {
                    ViewBag.Message = "Email e/ou senha invalidos!";
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Login));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Perfil()
        {
            //A variável é inicializada aqui, eu uso o HttpContext pra pegar o cpf do usuario logado
            usuarioCpf =  HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userLogged = await _context.Usuarios.FindAsync(usuarioCpf);
            return View(userLogged);
        }

        //DETAILS
        [Authorize]
        public async Task<IActionResult> Details()
        {
            //Como o cpf é uma variavel da classe, eu consigo usar ela aqui
            if (usuarioCpf == null) 
            {
                return NotFound();
            }

            //Aqui
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.CPF == usuarioCpf);

            if (usuario == null) 
            {
                return NotFound();
            }

            return View(usuario);
        }

        //DELETE
        [Authorize]
        public async Task<IActionResult> Delete()
        {
            //Aqui
            if (usuarioCpf == null)
               { 
                return NotFound();
               }

            //E aqui, dai não precisa ficar pegando o cpf em todos os métodos :D
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.CPF == usuarioCpf);

            if (usuario == null) 
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed()
        {
            var usuario = await _context.Usuarios.FindAsync(usuarioCpf);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Login));
        }

        /**
         * Acho que nem precisa desse método, talvez fosse mais interessante se
         * ele retornasse o usuario logado com o cpf
         * Eu mudaria o codigo pra esse await _context.Usuarios.FirstOrDefaultAsync(m => m.CPF == usuarioCpf);
         * E dai usaria essa função sempre que precisar retornar o usuario
         */
        private bool UsuarioExists(string id)
        {
            return _context.Usuarios.Any(e => e.CPF == id);
        }
    }
}
