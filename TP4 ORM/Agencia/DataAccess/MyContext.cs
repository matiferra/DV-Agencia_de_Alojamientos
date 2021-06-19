using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MyContext : DbContext
    {
        public MyContext() { }
        public DbSet<Alojamiento> Alojamiento { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<Cabania> Cabania { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<AgenciaManager> AgenciaManager { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = basedv.ddns.net\DVTN;Initial Catalog = TP4; User Id = matias.ferrario@davinci.edu.ar; Password=Dv2021");
        }


      




    }
}
