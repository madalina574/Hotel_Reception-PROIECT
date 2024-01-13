using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_Reception_PROIECT.Models;

namespace Hotel_Reception_PROIECT.Data
{
    public class Hotel_Reception_PROIECTContext : DbContext
    {
        public Hotel_Reception_PROIECTContext (DbContextOptions<Hotel_Reception_PROIECTContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel_Reception_PROIECT.Models.Oaspete> Oaspete { get; set; } = default!;

        public DbSet<Hotel_Reception_PROIECT.Models.Cazare>? Cazare { get; set; }

        public DbSet<Hotel_Reception_PROIECT.Models.Parcare>? Parcare { get; set; }
    }
}
