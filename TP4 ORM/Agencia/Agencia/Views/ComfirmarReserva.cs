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
    public partial class ComfirmarReserva : Form
    {
        Bussines.AgenciaManager Ag = new Bussines.AgenciaManager();
        public ComfirmarReserva(BusquedaAlojamiento alojaPadre)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON COMFIRMAR
                       
            var recuperoDni = Ag.recuperoDni(Global.GlobalSessionNombre,Global.GlobalSessionPass);
            Entities.Usuario usuario = Ag.buscarUsuarioxDNI(recuperoDni);
            if (Ag.reservar(int.Parse(Id_text.Text), recuperoDni.ToString(), desdeFecha.Value, hastaFecha.Value))
            {
                MessageBox.Show("Reservó con éxito");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
             
        }
    }
}
