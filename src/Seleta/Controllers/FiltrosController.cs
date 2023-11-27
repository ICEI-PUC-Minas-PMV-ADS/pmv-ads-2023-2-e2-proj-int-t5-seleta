using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Mvc.Rendering;
>>>>>>> feature/AjustandoFuncionalidades
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
<<<<<<< HEAD
        
=======

>>>>>>> feature/AjustandoFuncionalidades
        public async Task<IActionResult> Index(string filtro)
        {
            IQueryable<Produto> produtosQuery = _context.Produtos.Include(e => e.Estabelecimento);

            var filtroRestricao = CriarFiltroResticao(filtro);
            if (!string.IsNullOrEmpty(filtro))
            {
<<<<<<< HEAD
                if (filtroRestricao == null)
                {
                    produtosQuery = produtosQuery.Where(p =>
                    p.Nome.Contains(filtro) ||
                    p.Descricao.Contains(filtro) ||
                    p.Categoria.Contains(filtro));
                }
                else
                {
                    produtosQuery = produtosQuery.Where(p => p.Restricoes.Equals(filtroRestricao));
                }
=======
                produtosQuery = produtosQuery.Where(p =>
                    p.Nome.Contains(filtro) ||
                    p.Descricao.Contains(filtro) ||
                    p.Categoria.Contains(filtro) ||
                    p.Estabelecimento.Endereco.Contains(filtro) ||
                    p.Estabelecimento.Nome.Contains(filtro));
>>>>>>> feature/AjustandoFuncionalidades
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

        private static object? CriarFiltroResticao(string filtro)
        {
            var palavraFiltro = "";
            var palavrasFiltro = filtro.Split(" ");
            foreach(var palavra in palavrasFiltro)
            {
                var palavraCaptalize = char.ToUpper(palavra[0]) + palavra[1..];
                palavraFiltro += palavraCaptalize;
            }

            try
            {
                return Enum.Parse(typeof(Restricoes), palavraFiltro);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}


