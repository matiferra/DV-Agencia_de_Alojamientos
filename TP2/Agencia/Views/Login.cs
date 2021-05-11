using Agencia.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia
{
    public partial class Login : Form
    {
        private Form1 form;
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

        String selec =seleccion.SelectedItem.ToString();
            if(selec == "Administrador")
            {
            Administrador admin = new Administrador();
            admin.MdiParent = form;
            admin.Show();
            this.Hide();

            } else if (selec == "Cliente")
            {
                Cliente client = new Cliente();
                client.MdiParent = form;
                client.Show();
                this.Hide();
            }

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
