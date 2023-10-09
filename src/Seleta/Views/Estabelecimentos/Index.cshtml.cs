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
    public class IndexModel : PageModel
    {
        private readonly Seleta.Data.ApplicationDbContext _context;

        public IndexModel(Seleta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Estabelecimento> Estabelecimento { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Estabelecimentos != null)
            {
                Estabelecimento = await _context.Estabelecimentos.ToListAsync();
            }
        }
    }
}
