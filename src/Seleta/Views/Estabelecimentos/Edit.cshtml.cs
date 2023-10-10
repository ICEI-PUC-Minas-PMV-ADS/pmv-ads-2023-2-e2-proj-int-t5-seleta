using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Views.Estabelecimentos
{
    public class EditModel : PageModel
    {
        private readonly Seleta.Data.ApplicationDbContext _context;

        public EditModel(Seleta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Estabelecimento Estabelecimento { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estabelecimentos == null)
            {
                return NotFound();
            }

            var estabelecimento =  await _context.Estabelecimentos.FirstOrDefaultAsync(m => m.Cnpj == id);
            if (estabelecimento == null)
            {
                return NotFound();
            }
            Estabelecimento = estabelecimento;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Estabelecimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstabelecimentoExists(Estabelecimento.Cnpj))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EstabelecimentoExists(int id)
        {
          return _context.Estabelecimentos.Any(e => e.Cnpj == id);
        }
    }
}
