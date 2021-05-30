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
    public partial class AdmUsuarios : Form
    {
        static Bussines.Agencia a = new Bussines.Agencia();
        static Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);

        Usuario usuario = null;
        Usuario usuarioEnMemoria = null;

        private Form currentChildForm;

        public AdmUsuarios()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);

        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void AdmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            /*string DNI = buscarText.Text;
            foreach (var item in ag.misUsuarios)
            {

                if (item.DNI == DNI)
                {
                    usuario = item;
                }
            }
            
            if(usuario != null)
            {
                DNIText.Text = usuario.DNI + "";
                passText.Text = usuario.password;
                mailText.Text = usuario.mail;
                nombreText.Text = usuario.nombre;
                if(usuario.esAdmin == true)
                {
                    TipoCombo.SelectedItem = "Administrador";
                } else
                {
                    TipoCombo.SelectedItem = "Cliente";
                }
                usuario = null;
                usuarioEnMemoria = usuario;
            } else
            {
                DNIText.Text = "Ingrese DNI";
                passText.Text = "Ingrese contraseña";
                mailText.Text = "Ingrese e-mail";
                nombreText.Text = "Ingrese nombre";
            }
            */
        }

        private void desbloquearButton_Click(object sender, EventArgs e)
        {
            foreach (var item in ag.misUsuarios)
            {
                if (usuarioEnMemoria.DNI == item.DNI)
                {
                    ag.desbloquearUsuario(item.DNI);
                }
            }
        }
            

        private void editarButton_Click(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            foreach (var item in ag.misUsuarios)
            {
                if (usuarioEnMemoria.DNI == item.DNI)
                {
                    ag.eliminarUsuario(item.DNI);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
