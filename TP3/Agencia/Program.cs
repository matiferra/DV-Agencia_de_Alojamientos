using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agencia.Views;
using System.IO;

namespace Agencia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //cargarUsuarios();
            //cargarAlojamientos();
            Application.Run(new Form1());
        }

       /* public static void cargarUsuarios()
        {
            string fileName = "usuarios.txt";
            string sourcePath = @"C:\PlataformasTP";
            string sourceFile = Path.Combine(sourcePath + @"\Usuarios", fileName);


            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
                Directory.CreateDirectory(sourcePath + @"\Usuarios");
            }

            string[] datos = { "2522212", "admin", "admin@admin", "123456", "true", "false", " ",
                               "12558444","fedevazquez","fede.vazquez@gmail.com","fedefede","true","false", " ",
                                "40225789", "dinosante", "dino.santelises@gmail.com","dinodino",  "false", "true", " ",
                                "45778963", "gabocordoba", "cordoba@gmail.com", "gabogabo", "false", "false", " ",
                                "30111598", "gianpool", "pool@gmail.com","giangian", "false", "false", " ",
                                "35292444", "matiferra", "ferrario@gmail.com", "matiasmatias", "false", "false", " ",
                                "00000000", " ","ferrarioCliente@gmail.com", "", "false", "false", " ",
                                "11111111", "","ferrario@gmail.com", "", "true", "false", " "
                                };
            if (!File.Exists(sourceFile))
            {
                File.WriteAllLines(sourceFile, datos);
            }
        }


        public static void cargarAlojamientos()
        {
            string fileName = "alojamientos.txt";
            string sourcePath = @"C:\PlataformasTP";
            string sourceFile = Path.Combine(sourcePath + @"\Alojamientos", fileName);


            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);

            }
            if (!Directory.Exists(sourcePath + @"\Alojamientos"))
            {
                Directory.CreateDirectory(sourcePath + @"\Alojamientos");
            }

            string[] datos = {  "Hotel", "CABA", "Belgrano", "******", "3", "true", "700", "N° de habitaciones", "N° de baños", " ",
                                "Hotel", "CABA", "Recoleta", "******", "2", "true", "1000", "N° de habitaciones", "N° de baños", " ",
                                "Hotel", "Tres Arroyos", "Solano", "****", "4", "false",  "500", "N° de habitaciones",  "N° de baños", " ",
                                "Hotel", "Pergamino", "Don Bosco", "**", "2", "true", "400", "N° de habitaciones", "N° de baños", " ",
                                "Hotel", "Tres Arroyos", "La liguria", "***", "1", "false", "800", "N° de habitaciones", "N° de baños", " ",
                                "Hotel", "Pergamino", "Santa Catarina", "*", "2", "true", "400", "N° de habitaciones", "N° de baños", " ",
                                "Cabaña", "Zarate", "Santa Rita", "***", "10", "true", "4000", "6", "2", " ",
                                "Cabaña", "Santo Tome", "Villa Pueyrredon", "****", "8", "true", "3000", "4", "2", " ",
                                "Cabaña", "Necochea", "Fiorito", "*", "8", "false", "1000", "4", "1", " "
                                };
            if (!File.Exists(sourceFile))
            {
                File.WriteAllLines(sourceFile, datos);
            }
        }*/
    }
}
