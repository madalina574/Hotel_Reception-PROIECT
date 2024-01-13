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
    public class DeleteModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public DeleteModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Parcare Parcare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Parcare == null)
            {
                return NotFound();
            }

            var parcare = await _context.Parcare.FirstOrDefaultAsync(m => m.ID == id);

            if (parcare == null)
            {
                return NotFound();
            }
            else 
            {
                Parcare = parcare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Parcare == null)
            {
                return NotFound();
            }
            var parcare = await _context.Parcare.FindAsync(id);

            if (parcare != null)
            {
                Parcare = parcare;
                _context.Parcare.Remove(Parcare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
