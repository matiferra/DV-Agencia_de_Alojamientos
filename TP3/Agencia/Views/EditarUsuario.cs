using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia.Views
{
    public partial class EditarUsuario : Form
    {
        //static Bussines.Agencia a = new Bussines.Agencia();
        static Bussines.AgenciaManager ag = new Bussines.AgenciaManager();
        public EditarUsuario(AdmUsuarios admUsuarios)
        {
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object serder, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventArgsHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventArgsHandler.Invoke(this, args);
        }


        private void Agrego_botonUsuario_Click(object sender, EventArgs e)
        {

            if (ag.modificarUsuario(int.Parse(textBox_dni.Text),text_nombre.Text,textBox_mail.Text,textBox_contras.Text,check_esadmin.Checked,false))
            {
                MessageBox.Show("Agregado con éxito");
                agregar();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo Modificar el Usuario");
            }

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
