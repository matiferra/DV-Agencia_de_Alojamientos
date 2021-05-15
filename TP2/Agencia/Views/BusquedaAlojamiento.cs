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

namespace Agencia.Views
{
    public partial class BusquedaAlojamiento : Form
    {
        AgenciaManager Ag = new AgenciaManager();
        public BusquedaAlojamiento()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_ciudad.Text) && !string.IsNullOrEmpty(text_fechad.Text) && !string.IsNullOrEmpty(text_fechah.Text)
              && !string.IsNullOrEmpty(text_cantidad.Text) && !string.IsNullOrEmpty(seleccion_tipo.Text))
            {

                var Lista = Ag.buscarAlojamientos(text_ciudad.Text, DateTime.Parse(text_fechad.Text),
                                             DateTime.Parse(text_fechah.Text), int.Parse(text_cantidad.Text), seleccion_tipo.Text);


                for (int i = 0; i < Lista.Count; i++)
                {
                    //adicionamos un row
                    dataGridView1.Rows.Add();
                    //colocamos la info
                    dataGridView1.Rows[i].Cells[0].Value = Lista.ToString();
                }

               

                //limpío los campos de los filtros

                //text_localidad.Text = "";
                //text_fecha.Text = "";
                //text_fecha.Text = "";
                //text_cantidad.Text = "";
                //seleccion_tipo_aloj.Text = "";
            }
            else
            {
                //mesajeError.Visible = true;
                //mesajeError.Text = "Todos los campos son requeridos!!";

            }

            this.Hide();
            ResultadoBusqueda rb = new ResultadoBusqueda();
            rb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BusquedaAlojamiento_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
