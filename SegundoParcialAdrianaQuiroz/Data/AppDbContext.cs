using Microsoft.EntityFrameworkCore;
using SegundoParcialAdrianaQuiroz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAdrianaQuiroz.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Agregar los modelos a utilizar
        public DbSet<Suerte> Suerte { get; set; }
    }
}
