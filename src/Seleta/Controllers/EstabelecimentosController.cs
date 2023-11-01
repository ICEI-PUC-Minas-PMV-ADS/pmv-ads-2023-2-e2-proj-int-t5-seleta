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

        public EstabelecimentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var usuarioLogadoCPF = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var dados = await _context.Estabelecimentos.
                Where(estabelecimento => estabelecimento.UsuarioCPF == usuarioLogadoCPF).ToListAsync();

            return View(dados);
        }

        //CREATE
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Estabelecimento estabelecimento)
        {
            var usuarioCPF = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var usuario = await _context.Usuarios.FindAsync(usuarioCPF);
            estabelecimento.Usuario = usuario;
            estabelecimento.UsuarioCPF = usuarioCPF;

            if (ModelState.IsValid)
            {
                _context.Estabelecimentos.Add(estabelecimento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(estabelecimento);
        }

        //EDIT
        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Estabelecimentos.FindAsync(id);

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, Estabelecimento estabelecimento)
        {
            if (id != estabelecimento.Cnpj)
                return NotFound();

            var usuario = await _context.Usuarios.FindAsync(estabelecimento.UsuarioCPF);
            estabelecimento.Usuario = usuario;

            if (ModelState.IsValid)
            {
                _context.Estabelecimentos.Update(estabelecimento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(estabelecimento);
        }

        //DETAILS

        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Estabelecimentos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        //DELETE

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Estabelecimentos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string? id)
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