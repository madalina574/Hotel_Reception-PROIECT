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
    public class DeleteModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public DeleteModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Cazare == null)
            {
                return NotFound();
            }
            var cazare = await _context.Cazare.FindAsync(id);

            if (cazare != null)
            {
                Cazare = cazare;
                _context.Cazare.Remove(Cazare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
