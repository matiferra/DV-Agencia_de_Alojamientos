using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //txt
            //cargar List<>



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cargarAdministradores();
            Application.Run(new Login());
        }

        public static void cargarAdministradores()
        {
            string fileName = "usuarios.txt";
            string sourcePath = @"C:\plataformas";
            string sourceFile = Path.Combine(sourcePath + @"\USER", fileName);


            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
                Directory.CreateDirectory(sourcePath + @"\USER");
            }

            string[] datos = {"2522212", "admin", "admin@admin", "123456", "true", "false", " " };
            if (!File.Exists(sourceFile))
            {
                File.WriteAllLines(sourceFile, datos);
            }
        }
    }
}
