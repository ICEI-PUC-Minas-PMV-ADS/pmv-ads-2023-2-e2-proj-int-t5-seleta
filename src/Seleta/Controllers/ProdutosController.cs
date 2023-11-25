using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static string cnpjEstabelecimentoSalvo;

        public ProdutosController(ApplicationDbContext context) 
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index(string cnpjEstabelecimento)
        {
            if (cnpjEstabelecimento != null) cnpjEstabelecimentoSalvo = cnpjEstabelecimento;

            var ApplicationDbContext = _context.Produtos.Include(e => e.Estabelecimento)
                .Where(produto => produto.CnpjEstabelecimento == cnpjEstabelecimentoSalvo);
            return View(await ApplicationDbContext.ToListAsync());
        }

        //CREATE

        [Authorize]
        public IActionResult Create()
        {
            ViewData["CnpjEstabelecimento"] = new SelectList(_context.Estabelecimentos, "Cnpj", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id, Nome, Preco, QuantidadePeso, Categoria, Descricao, Restricoes, CnpjEstabelecimento")] Produto produto, IFormFile imagem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (imagem != null && imagem.Length > 0)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await imagem.CopyToAsync(stream);
                            produto.Imagem = stream.ToArray();
                            produto.TipoImagem = imagem.ContentType;
                        }
                    }

                    _context.Produtos.Add(produto);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Ocorreu um erro durante a criação do produto.");
            }

            ViewData["CnpjEstabelecimento"] = new SelectList(_context.Estabelecimentos, "Cnpj", "Nome", produto.CnpjEstabelecimento);
            return View("Create", produto ?? new Produto());
        }

        //EDIT
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }
                
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            ViewData["CnpjEstabelecimento"] = new SelectList(_context.Estabelecimentos, "Cnpj", "Nome");
            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind ("Id, Nome, Preco, QuantidadePeso, Categoria, Descricao, Restricoes, CnpjEstabelecimento")] Produto produto, IFormFile novaImagem)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (novaImagem != null && novaImagem.Length > 0)
                    {
                        var stream = new MemoryStream();
                        await novaImagem.CopyToAsync(stream);
                        produto.Imagem = stream.ToArray();
                        produto.TipoImagem = novaImagem.ContentType;
                    }

                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            ViewData["CnpjEstabelecimento"] = new SelectList(_context.Estabelecimentos, "Cnpj", "Nome", produto.CnpjEstabelecimento);
            return View(produto);
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

        //DELETE
        public async Task<IActionResult> Delete(int? id)
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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Produtos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Produtos' is null.");
            }

            var produto = await _context.Produtos.FindAsync(id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);   
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}

