using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MyContext : DbContext
    {
        public MyContext() { }
        public DbSet<Alojamiento> Alojamiento { get; set; }
        //public DbSet<Alojamiento> Alojamiento { get; set; }

        //public DbSet<Alojamiento> Alojamiento { get; set; }

        //public DbSet<Alojamiento> Alojamiento { get; set; }

        //public DbSet<Alojamiento> Alojamiento { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = basedv.ddns.net\DVTN;Initial Catalog = TP4; User Id = matias.ferrario@davinci.edu.ar; Password=Dv2021");
        }


      




    }
}
