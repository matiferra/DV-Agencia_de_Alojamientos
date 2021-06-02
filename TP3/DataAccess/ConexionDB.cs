﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class ConexionDB
    {
        //Cadena de Conexion
        //string cadena = @"Data Source = DESKTOP-ED5CATB\SQLEXPRESS;Initial Catalog = TPAgencia; User Id = sa; Password=123456";
        //string cadena = @"Data Source = basedv.ddns.net\DVTN;Initial Catalog = TPAgencia; User Id = matias.ferrario@davinci.edu.ar; Password=Dv2021";
        string cadena = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
        public SqlConnection Conectarbd = new SqlConnection();
        //Constructor
        public ConexionDB()
        {
            Conectarbd.ConnectionString = cadena;
        }
        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                // Console.WriteLine("conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }
        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}
