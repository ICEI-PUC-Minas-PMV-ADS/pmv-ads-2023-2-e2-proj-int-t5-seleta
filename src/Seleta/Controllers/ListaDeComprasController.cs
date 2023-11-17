using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Controllers
{
    public class ListaDeComprasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const string SessionListaDeCompras = "listaDeComprasAcessada";

        public ListaDeComprasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaDeComprasEmail = HttpContext.Session.GetString(SessionListaDeCompras);
            var produtosDaLista = _context.ProdutosListaDeCompras
                .Where(lista => lista.ListaDeComprasEmail == listaDeComprasEmail)
                .Select(lista => lista.Produto).ToList();
            ViewData["ListaDeComprasEmail"] = listaDeComprasEmail;
            return View(produtosDaLista);
        }

        [HttpPost]
        public async Task<IActionResult> ConsultaLista(ListaDeCompras listaDeCompras)
        {
            if (listaDeCompras != null && ModelState.IsValid)
            {
                var listaDeComprasExiste = await _context.ListasDeCompras
                    .FirstOrDefaultAsync(lista => lista.Email == listaDeCompras.Email);

                if (listaDeComprasExiste == null)
                {
                    await CriarNovaLista(listaDeCompras);
                }

                HttpContext.Session.SetString(SessionListaDeCompras, listaDeCompras.Email);
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index), "Home");
        }

        [HttpGet]
        public async Task<IActionResult> SalvarProduto(int produtoId)
        {
            var produto = await _context.Produtos
                .Include(e => e.Estabelecimento)
                .FirstOrDefaultAsync(m => m.Id == produtoId);
            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> SalvarProdutoConfirmado(int produtoId)
        {
            var listaDeComprasLogada = HttpContext.Session.GetString(SessionListaDeCompras);
            if (listaDeComprasLogada == null)
            {
                return RedirectToAction(nameof(Index), "Home");
            }

            var produtosListaDeCompras = await GerarProdutosListaDeCompras(produtoId, listaDeComprasLogada);
            _context.ProdutosListaDeCompras.Add(produtosListaDeCompras);
            await _context.SaveChangesAsync();

            
            return RedirectToAction(nameof(Index));
        }

        private async Task CriarNovaLista(ListaDeCompras listaDeCompras)
        {
            await _context.ListasDeCompras.AddAsync(listaDeCompras);
            _context.SaveChanges();
        }

        private async Task<ProdutosListaDeCompras> GerarProdutosListaDeCompras(int produtoId, string listaDeComprasEmail)
        {
            var produto = await _context.Produtos.Include(e => e.Estabelecimento)
                .FirstOrDefaultAsync(m => m.Id == produtoId);

            var listaDeCompras = await _context.ListasDeCompras.FindAsync(listaDeComprasEmail);

            return new ProdutosListaDeCompras
            {
                ProdutoId = produtoId,
                Produto = produto,
                ListaDeComprasEmail = listaDeComprasEmail,
                ListaDeCompras = listaDeCompras
            };
        }
    }
}
