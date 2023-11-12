using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Controllers
{
    public class ListaDeComprasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static string listaComprasEmail;

        public ListaDeComprasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var produtosDaLista = await _context.ListasDeCompras
                .FirstAsync(lista => lista.Email == listaComprasEmail);
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

                listaComprasEmail = listaDeCompras.Email;
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index), nameof(HomeController));
        }

        private async Task CriarNovaLista(ListaDeCompras listaDeCompras)
        {
            await _context.ListasDeCompras.AddAsync(listaDeCompras);
            _context.SaveChanges();
        }
    }
}
