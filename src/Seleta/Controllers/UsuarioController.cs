using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;
using Seleta.Models.ViewModel;
using System.Security.Claims;

namespace Seleta.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        private static string? usuarioCpf;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUsuarioViewModel usuario)
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
        public async Task<IActionResult> Cadastro(CadastroUsuarioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    CPF = viewModel.CPF,
                    Nome = viewModel.Nome,
                    Email = viewModel.Email,
                    Senha = viewModel.Senha,
                };

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
            usuarioCpf =  HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userLogged = await _context.Usuarios.FindAsync(usuarioCpf);
            return View(userLogged);
        }

        //DETAILS
        [Authorize]
        public async Task<IActionResult> Details()
        {
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
    }
}
