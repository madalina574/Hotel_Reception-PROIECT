using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel_Reception_PROIECT.Data;
using Hotel_Reception_PROIECT.Models;

namespace Hotel_Reception_PROIECT.Pages.Oaspeti
{
    public class EditModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public EditModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
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

            var oaspete =  await _context.Oaspete.FirstOrDefaultAsync(m => m.ID == id);
            if (oaspete == null)
            {
                return NotFound();
            }
            Oaspete = oaspete;
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

            _context.Attach(Oaspete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OaspeteExists(Oaspete.ID))
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

        private bool OaspeteExists(int id)
        {
          return (_context.Oaspete?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
