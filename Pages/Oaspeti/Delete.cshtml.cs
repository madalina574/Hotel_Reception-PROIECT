using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hotel_Reception_PROIECT.Data;
using Hotel_Reception_PROIECT.Models;

namespace Hotel_Reception_PROIECT.Pages.Oaspeti
{
    public class DeleteModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public DeleteModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Oaspete Oaspete { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Oaspete == null)
            {
                return NotFound();
            }

            var oaspete = await _context.Oaspete.FirstOrDefaultAsync(m => m.ID == id);

            if (oaspete == null)
            {
                return NotFound();
            }
            else 
            {
                Oaspete = oaspete;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Oaspete == null)
            {
                return NotFound();
            }
            var oaspete = await _context.Oaspete.FindAsync(id);

            if (oaspete != null)
            {
                Oaspete = oaspete;
                _context.Oaspete.Remove(Oaspete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
