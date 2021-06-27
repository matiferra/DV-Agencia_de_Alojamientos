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
    public partial class AdmReservas : Form
    {

        Bussines.AgenciaManager Ag = new Bussines.AgenciaManager();
        public AdmReservas()
        {
            InitializeComponent();
            combo_ciudadHeader.DisplayMember = "nombre";
            combo_ciudadHeader.ValueMember = "id";
            combo_ciudadHeader.DataSource = Ag.getCiudades();

            panel1.BackColor = Color.FromArgb(60, Color.Black);
        }

        public void RefresVista()
        {
            dataGridViewReservas.Rows.Clear();
            List<List<string>> reservas = Ag.getTodasLasReservas();

            foreach (List<string> lista in reservas)
                dataGridViewReservas.Rows.Add(lista.ToArray());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdmReservas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // MOSTRAR TODAS
        {
            dataGridViewReservas.Rows.Clear();
            List<List<string>> reservas = Ag.getTodasLasReservas();

            foreach (List<string> lista in reservas)
                dataGridViewReservas.Rows.Add(lista.ToArray());
        }



        private void dataGridViewReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewReservas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult dr = MessageBox.Show("Seguro que deseea eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.dataGridViewReservas.Rows[e.RowIndex].Cells[5].Value.ToString());
                    if (Ag.eliminarReserva(id))
                      {
                          MessageBox.Show("RESERVA ELIMINADA");
                      }
                      RefresVista();
                    
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dataGridViewReservas.Rows.Clear();
            List<List<string>> reservas = Ag.getTodasLasReservasxCiudad(combo_ciudadHeader.Text);

            foreach (List<string> lista in reservas)
                dataGridViewReservas.Rows.Add(lista.ToArray());
        }
    }
}
