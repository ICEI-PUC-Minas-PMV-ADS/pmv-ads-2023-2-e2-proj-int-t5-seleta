using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Seleta.Data;
using Seleta.Models;

namespace Seleta.Views.Estabelecimentos
{
    public class DeleteModel : PageModel
    {
        private readonly Seleta.Data.ApplicationDbContext _context;

        public DeleteModel(Seleta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Estabelecimento Estabelecimento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estabelecimentos == null)
            {
                return NotFound();
            }

            var estabelecimento = await _context.Estabelecimentos.FirstOrDefaultAsync(m => m.Cnpj == id);

            if (estabelecimento == null)
            {
                return NotFound();
            }
            else 
            {
                Estabelecimento = estabelecimento;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Estabelecimentos == null)
            {
                return NotFound();
            }
            var estabelecimento = await _context.Estabelecimentos.FindAsync(id);

            if (estabelecimento != null)
            {
                Estabelecimento = estabelecimento;
                _context.Estabelecimentos.Remove(Estabelecimento);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
