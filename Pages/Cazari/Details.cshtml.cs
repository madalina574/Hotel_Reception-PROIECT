using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel_Reception_PROIECT.Data;
using Hotel_Reception_PROIECT.Models;

namespace Hotel_Reception_PROIECT.Pages.Cazari
{
    public class DetailsModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public DetailsModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
        {
            _context = context;
        }

      public Cazare Cazare { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cazare == null)
            {
                return NotFound();
            }

            var cazare = await _context.Cazare.FirstOrDefaultAsync(m => m.ID == id);
            if (cazare == null)
            {
                return NotFound();
            }
            else 
            {
                Cazare = cazare;
            }
            return Page();
        }
    }
}
