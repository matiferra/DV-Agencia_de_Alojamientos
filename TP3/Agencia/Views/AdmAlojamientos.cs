﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bussines;

namespace Agencia.Views
{
    public partial class AdmAlojamientos : Form
    {
        AgenciaManager Ag = new AgenciaManager();
        public Bussines.AgenciaManager agencia { get; set; }

        static string fileName = "alojamientos.txt";
        static string sourcePath = @"C:\plataformas";
        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);

        string tv;
        string ciudad;
        string barrio;
        string estrellas;
        string tipoAlojamiento;
        string personas;
        string precio;
        string habitaciones;
        string banios;


        public AdmAlojamientos()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
            RefresVista();

        }
        private void RefresVista()
        {
            alojamientosGrid.Rows.Clear();
            DataSet Lista = Ag.obtenerAlojamientos();
            int index = 0;
            if (Lista.Tables[0] != null && Lista.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in Lista.Tables[0].Rows)
                {
                    alojamientosGrid.Rows.Add();
                    alojamientosGrid.Rows[index].Cells[2].Value = dr["id_alojamiento"].ToString();
                    alojamientosGrid.Rows[index].Cells[3].Value = dr["barrio"].ToString();
                    alojamientosGrid.Rows[index].Cells[4].Value = int.Parse(dr["estrellas"].ToString());
                    alojamientosGrid.Rows[index].Cells[5].Value = dr["cantidadDePersonas"].ToString();
                    alojamientosGrid.Rows[index].Cells[6].Value = dr["tv"].ToString();
                    alojamientosGrid.Rows[index].Cells[7].Value = dr["eshotel"].ToString();
                    alojamientosGrid.Rows[index].Cells[8].Value = dr["id_ciudad"].ToString();
                    alojamientosGrid.Rows[index].Cells[9].Value = dr["cantidad_de_habitaciones"].ToString();
                    alojamientosGrid.Rows[index].Cells[10].Value = dr["precio_por_dia"].ToString();
                    alojamientosGrid.Rows[index].Cells[11].Value = dr["precio_por_persona"].ToString();
                    alojamientosGrid.Rows[index].Cells[12].Value = dr["cantidadDeBanios"].ToString();

                    index++;

                }
            }
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void AdmAlojamientos_Load(object sender, EventArgs e)
        {
            precioText.Visible = false;
            personasText.Visible = false;
            LBaños.Visible = false;
            LHabitaciones.Visible = false;
            LDiaOPer.Visible = false;
            LPersonas.Visible = false;
            habitacionesText.Visible = false;
            baniosText.Visible = false;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }


     
        private void AdmAlojamientos_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selec = tipoAlojamientoCombo.SelectedItem.ToString();


            if (selec == "Cabaña")
            {
                LBaños.Visible = true;
                LHabitaciones.Visible = true;
                baniosText.Visible = true;
                habitacionesText.Visible = true;
                LDiaOPer.Text = "Precio por dia";
                LPersonas.Visible = true;
                precioText.Visible = true;
                personasText.Visible = true;
            }
            else if (selec == "Hotel")
            {
                LBaños.Visible = false;
                LHabitaciones.Visible = false;
                baniosText.Visible = false;
                habitacionesText.Visible = false;
                LDiaOPer.Text = "Precio por persona";
                LPersonas.Visible = true;
                LDiaOPer.Visible = true;
                precioText.Visible = true;
                personasText.Visible = true;

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check_tv.Checked)
            {
                tv = "true";
            }
            else
            {
                tv = "false";
            }
            ciudad = ciudadText.Text;
            barrio = barrioText.Text;
            estrellas = estrellasText.Text;
            tipoAlojamiento = tipoAlojamientoCombo.Text;
            personas = personasText.Text;
            precio = precioText.Text;
            habitaciones = habitacionesText.Text;
            banios = baniosText.Text;


            string[] datos = { tipoAlojamiento, ciudad, barrio, estrellas, personas, tv, precio, habitaciones, banios, " " };
            if (!File.Exists(sourceFile))
            {
                File.WriteAllLines(sourceFile, datos);
            }
            else
            {
                foreach (var item in datos)
                {
                    File.AppendAllText(sourceFile, item + Environment.NewLine);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //alojamientosGrid.Rows.Clear();
            //foreach (List<string> alojamiento in agencia.obtenerAlojamientos())
            //{
            //    alojamientosGrid.Rows.Add(alojamiento.ToArray());
            //}
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            if (Ag.agregarAlojamiento(tipoAlojamientoCombo.Text, ciudadText.Text, barrioText.Text, estrellasText.Text,
                                  personasText.Text, check_tv.Checked, precioText.Text, habitacionesText.Text, baniosText.Text))
            {

                MessageBox.Show("Agregado con éxito");
                alojamientosGrid.Rows.Clear();
                RefresVista();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el alojamiento");
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tvSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void alojamientosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.alojamientosGrid.Columns[e.ColumnIndex].Name == "Eliminar_aloja")
            {
                DialogResult dr = MessageBox.Show("Seguro que deseea eliminar?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
               
                if (dr == DialogResult.Yes)
                {
                    var id = this.alojamientosGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Ag.quitarAlojamiento(int.Parse(id));
                    RefresVista();

                }
             
            }
            else if (this.alojamientosGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                MessageBox.Show("pendiente editar");
            }

        }
    }
}
