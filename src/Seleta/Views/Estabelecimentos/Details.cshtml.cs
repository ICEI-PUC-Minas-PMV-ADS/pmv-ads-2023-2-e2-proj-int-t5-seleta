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
    public class DetailsModel : PageModel
    {
        private readonly Seleta.Data.ApplicationDbContext _context;

        public DetailsModel(Seleta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
