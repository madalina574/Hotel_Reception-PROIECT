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
    public class DetailsModel : PageModel
    {
        private readonly Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext _context;

        public DetailsModel(Hotel_Reception_PROIECT.Data.Hotel_Reception_PROIECTContext context)
        {
            _context = context;
        }

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
    }
}
