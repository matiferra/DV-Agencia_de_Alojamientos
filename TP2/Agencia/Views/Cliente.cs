using Bussines;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Agencia.Views
{
    public partial class Cliente : Form
    {
        AgenciaManager Ag = new AgenciaManager();

        public Cliente()
        {          
            InitializeComponent();
            mesajeError.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_localidad.Text) && !string.IsNullOrEmpty(text_fecha.Text) && !string.IsNullOrEmpty(text_fecha.Text) 
                && !string.IsNullOrEmpty(text_cantidad.Text) && !string.IsNullOrEmpty(seleccion_tipo_aloj.Text))
            {

                var Lista = Ag.buscarAlojamientos(text_localidad.Text, DateTime.Parse(text_fecha.Text),
                                             DateTime.Parse(text_fecha.Text), int.Parse(text_cantidad.Text), seleccion_tipo_aloj.Text);


                for (int i = 0; i < Lista.Count; i++)
                {
                    //adicionamos un row
                    dataGridView1.Rows.Add();
                    //colocamos la info
                    dataGridView1.Rows[i].Cells[0].Value = Lista.ToString();
                }

                //limpío los campos de los filtros

                text_localidad.Text = "";
                text_fecha.Text = "";
                text_fecha.Text = "";
                text_cantidad.Text = "";
                seleccion_tipo_aloj.Text = "";

            }
            else
            {
                mesajeError.Visible = true;
                mesajeError.Text = "Todos los campos son requeridos!!";

            }
          

        }     

       

    }
}
