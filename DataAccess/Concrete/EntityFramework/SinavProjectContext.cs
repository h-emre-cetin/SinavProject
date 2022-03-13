using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class SinavProjectContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SinavProjectDb;Trusted_Connection=true");
        }


        public DbSet<Sik> Siks { get; set; }
        public DbSet<Sinav> Sinavs { get; set; }
        public DbSet<SinavKategori> SinavKategoris { get; set; }

        public DbSet<Soru> Sorus { get; set; }

        public DbSet<SoruKategori> SoruKategoris { get; set; }
    }
}
