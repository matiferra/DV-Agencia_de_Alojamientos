using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MyContext : DbContext
    {


        //PARA LO ULTIMO -> MODELAR MODELOS

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
            try
            {
                optionsBuilder.UseSqlServer(@"Data Source = basedv.ddns.net\DVTN;Initial Catalog =testTp4; User Id = matias.ferrario@davinci.edu.ar; Password=Dv2021");
            }
            catch (Exception e)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Usuario>().HasData(

                 new Usuario { id = 1, DNI = 12345678, nombre = "admin", pass = "123", esAdmin = true, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 },
                 new Usuario { id = 2, DNI = 12345678, nombre = "gianpool", pass = "123", esAdmin = false, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 }

                );


        }








    }
}
