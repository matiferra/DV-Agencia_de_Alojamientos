using Bussines;
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
    public partial class RecuperarContraseña : Form
    {
        AgenciaManager Ag = new AgenciaManager();
        public Bussines.Usuario usuario { get; set; }
        public RecuperarContraseña()
        {

        InitializeComponent();

            panel1.BackColor = Color.FromArgb(60, Color.Black);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           //string respuesta = Ag.cambiarContrasenia("99999", pass_old.Text, pass_new.Text, pass_reingrese.Text); 

           // MessageBox.Show(respuesta);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string dni = Ag.recuperoDni(Global.GlobalSessionNombre, Global.GlobalSessionPass);
            string respuesta = Ag.cambiarContrasenia(dni, pass_old.Text, pass_new.Text, pass_reingrese.Text);

            MessageBox.Show(respuesta);
            LimpioCampos();

        }

        private void LimpioCampos()
        {
            pass_old.Text = "";
            pass_new.Text = "";
            pass_reingrese.Text = "";
        }
    }
}
