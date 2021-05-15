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
 
namespace Agencia.Views
{
    public partial class AdmAlojamientos : Form
    {

 	    static string fileName = "alojamiento.txt";
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
            habitacionesText.Visible = false;
            baniosText.Visible = false;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void AdmAlojamientos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selec = tipoAlojamientoCombo.SelectedItem.ToString();


            if (selec == "Cabaña")
            {
                baniosText.Visible = true;
                habitacionesText.Visible = true;
                precioText.Text = "Precio por dia";
                personasText.Text = "N° de personas";
                precioText.Visible = true;
                personasText.Visible = true;
            } else if(selec == "Hotel")
            {
                baniosText.Visible = false;
                habitacionesText.Visible = false;
                precioText.Text = "Precio por persona";
                personasText.Text = "N° de personas";
                precioText.Visible = true;
                personasText.Visible = true;

            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tvSi.Checked)
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
          

            string[] datos = { tipoAlojamiento , ciudad, barrio, estrellas, personas, tv,  precio, habitaciones, banios, " "};
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
    }
}
