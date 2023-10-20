using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Controllers
{
    public class EstabelecimentosController : Controller
	{
		private readonly ApplicationDbContext _context;

		public EstabelecimentosController (ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index ()
		{
			var dados = await _context.Estabelecimentos.ToListAsync();

			return View(dados);
		}

		//CREATE

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public async Task<IActionResult> Create(Estabelecimento estabelecimento)
        {

			if (ModelState.IsValid)
			{
               var cpfUsuarioLogado = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (cpfUsuarioLogado != null)
                {
                    estabelecimento.UsuarioCPF = cpfUsuarioLogado;
                }

                _context.Estabelecimentos.Add(estabelecimento);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(estabelecimento);
        }

        //EDIT

        public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
				return NotFound();

			var dados = await _context.Estabelecimentos.FindAsync(id);

            if (id == null)
				return NotFound();


            return View(dados);
		}

        [HttpPost]
		public async Task<IActionResult> Edit(string id, Estabelecimento estabelecimento)
		{
			if (id != estabelecimento.Cnpj)
				return NotFound();

			if (ModelState.IsValid)
			{
				_context.Estabelecimentos.Update(estabelecimento);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(estabelecimento);
		}

		//DETAILS

		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
				return NotFound();

			var dados = await _context.Estabelecimentos.FindAsync(id);

			if (dados == null)
				return NotFound();

			return View(dados);
		}

        //DELETE

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Estabelecimentos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Estabelecimentos.FindAsync(id);

            if (dados == null)
                return NotFound();

			_context.Estabelecimentos.Remove(dados);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index");
        }

    }
}