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
        public DbSet<Entities.Alojamiento> Alojamiento { get; set; }
        public DbSet<Entities.Agencia> Agencia { get; set; }
        public DbSet<Entities.Reserva> Reserva { get; set; }
        public DbSet<Entities.Usuario> Usuario { get; set; }
        public DbSet<Entities.Ciudades> Ciudades { get; set; }
        public DbSet<Entities.AgenciaManager> AgenciaManager { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(@"Data Source = basedv.ddns.net\DVTN;Initial Catalog =tpPlataformas; User Id = matias.ferrario@davinci.edu.ar; Password=Dv2021");
            }
            catch (Exception e)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Entities.Usuario>().HasData(

                 new Entities.Usuario { id = 1, DNI = 000000, nombre = "fede", pass = "123", esAdmin = true, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 },
                 new Entities.Usuario { id = 2, DNI = 111111, nombre = "gianpool", pass = "123", esAdmin = false, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 },
                 new Entities.Usuario { id = 3, DNI = 222222, nombre = "matiferra", pass = "123", esAdmin = false, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 },
                 new Entities.Usuario { id = 4, DNI = 333333, nombre = "gabo", pass = "123", esAdmin = false, mail = "soporte@gmail.com", bloqueado = true, intentosLogueo = 0 },
                 new Entities.Usuario { id = 5, DNI = 444444, nombre = "dino", pass = "123", esAdmin = true, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 },
                 new Entities.Usuario { id = 6, DNI = 555555, nombre = "fran", pass = "123", esAdmin = false, mail = "soporte@gmail.com", bloqueado = false, intentosLogueo = 0 }

                );

            modelBuilder.Entity<Entities.Ciudades>().HasData(

                new Entities.Ciudades { id = 1, nombre = "buenos aires" },
                new Entities.Ciudades { id = 2, nombre = "rio negro" },
                new Entities.Ciudades { id = 3, nombre = "la plata" },
                new Entities.Ciudades { id = 4, nombre = "bariloche" },
                new Entities.Ciudades { id = 5, nombre = "lujan" }

               );


        }








    }
}
