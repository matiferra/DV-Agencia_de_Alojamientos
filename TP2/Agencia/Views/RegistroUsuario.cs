﻿using System;
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
    public partial class RegistroUsuario : Form
    {

        AgenciaManager ag = new AgenciaManager();
       
        public RegistroUsuario()
        {
            InitializeComponent();
        }

     

        private void registrarse_Click(object sender, EventArgs e)
        {
           ag.agregarUsuario(int.Parse(txtDocu.Text), txtUsername.Text, txtEmail.Text, txtPassword.Text, true, true );
            
        }

        
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
