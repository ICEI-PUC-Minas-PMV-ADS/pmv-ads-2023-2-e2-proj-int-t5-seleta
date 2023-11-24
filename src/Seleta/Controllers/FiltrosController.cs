using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Controllers
{
    public class FiltrosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FiltrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string filtro)
        {
            IQueryable<Produto> produtosQuery = _context.Produtos.Include(e => e.Estabelecimento);


            if (!string.IsNullOrEmpty(filtro))
            {
                produtosQuery = produtosQuery.Where(p =>
                    p.Nome.Contains(filtro) ||
                    p.Descricao.Contains(filtro) ||
                    p.Categoria.Contains(filtro) ||
                    p.Estabelecimento.Endereco.Contains(filtro) ||
                    p.Estabelecimento.Nome.Contains(filtro));
            }

            var produtos = await produtosQuery.ToListAsync();
            return View(produtos);
        }

    //DETAILS
    public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(e => e.Estabelecimento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

    }
}


