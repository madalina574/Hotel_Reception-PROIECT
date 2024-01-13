using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel_Reception_PROIECT.Data;
using Hotel_Reception_PROIECT.Models;

namespace Hotel_Reception_PROIECT.Pages.Parcari
{
    public class IndexModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public IndexModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
        {
            _context = context;
        }

        public IList<Parcare> Parcare { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Parcare != null)
            {
                Parcare = await _context.Parcare.ToListAsync();
            }
        }
    }
}
