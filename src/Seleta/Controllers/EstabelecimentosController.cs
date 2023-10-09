using System;
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

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Create(Estabelecimento estabelecimento)
        {

			if (ModelState.IsValid)
			{
				_context.Estabelecimentos.Add(estabelecimento);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index");
			}


			return View();
        }
    }
}

