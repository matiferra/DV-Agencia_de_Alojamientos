using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussines;
using System.IO;

namespace Agencia.Views
{
    public partial class ResultadoBusqueda : Form
    {

        static Bussines.Agencia a = new Bussines.Agencia();
   
        public ResultadoBusqueda()
        {
            InitializeComponent();
        }
        

        public void leerAlojamiento()
        {
            //LEER
            string fileName = "alojamientos.txt";
            string sourcePath = @"C:\plataformas";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string contenido = String.Empty;

            if (File.Exists(sourceFile))
            {
                contenido = File.ReadAllText(sourceFile);
                string[] lineas = contenido.Split(new[] { Environment.NewLine },
                                                    StringSplitOptions.None
                );
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
        //ARRAY
        /*if (datos[1] == "Hotel")
        {
            Bussines.Hotel hotel = new Bussines.Hotel(datos[2], datos[2], datos[2], datos[2], datos[2], datos[2],);

        }else
        {
            Bussines.Cabania cabania = new Bussines.Cabania(datos[2], datos[2], datos[2], datos[2], datos[2], datos[2],);

        }*/

    }
        Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);

        // CARGARLO EN  Agencia.misAlejomiento()


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            leerAlojamiento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerAlojamiento();
        }
    }
}
