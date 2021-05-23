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
            leerAlojamientos();
        }


        private void leerAlojamientos()
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

                //LINEAS DEL ARCHIVO
                //1 - Tipo Alojamiento
                //2 - ciudad
                //3 - barrio
                //4 - estrellas
                //5 - cantPersonas
                //6 - tv
                //7 - precio
                //8 - habitaciones
                //9 - banios

                for (int i = 0; i < lineas.Length; i++)
                {
                    try
                    {
                        if (lineas[i] == "Hotel")
                        {
                            //string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxPersona
                            Bussines.Hotel hotel = new Bussines.Hotel(lineas[i+1], lineas[i + 2], lineas[i+3], int.Parse(lineas[i+4]), bool.Parse(lineas[i+5]), Double.Parse(lineas[i+6]));
                            a.insertarAlojamiento(hotel);
                        }
                        else
                        {
                            //string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxDia, int habitaciones, int banios
                            Bussines.Cabania cabania = new Bussines.Cabania(lineas[1], lineas[2], lineas[3], int.Parse(lineas[4]), bool.Parse(lineas[5]), Double.Parse(lineas[6]), int.Parse(lineas[7]), int.Parse(lineas[8]));
                            
                            a.insertarAlojamiento(cabania);
                        }
                        i = i + 10;
                    } catch(Exception e)
                    {

                    }
                }
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }

        Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
