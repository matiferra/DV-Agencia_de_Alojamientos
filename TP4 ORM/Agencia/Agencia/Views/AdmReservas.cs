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
            List<List<string>> reservas = Ag.getTodasLasReservasxCiudad(combo_ciudadHeader.Text);

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
                    int id = int.Parse(this.dataGridViewReservas.Rows[e.RowIndex].Cells[6].Value.ToString());
                    if (Ag.eliminarReserva(id))
                      {
                          MessageBox.Show("RESERVA ELIMINADA");
                      }
                      RefresVista();
                    
                }
            }
            /*else if (this.dataGridViewReservas.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditarAlojamiento editar = new EditarAlojamiento(this);
                editar.UpdateEventArgsHandler += edit_aloj_UpddataGridViewReservasateHadler; //  metodo la cual me permite actualizar la grilla cuando termine de guardar los cambios

                editar.id_text.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[2].Value.ToString();
                editar.id_text.ReadOnly = true;
                editar.id_text.Visible = false;
                editar.label_id.Visible = false;
                editar.barrioText.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[3].Value.ToString();
                editar.estrellasText.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[4].Value.ToString();
                editar.personasText.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (this.dataGridViewReservas.Rows[e.RowIndex].Cells[6].Value.ToString() == "si")
                {
                    editar.check_tv.Checked = true;
                }
                else
                {
                    editar.check_tv.Checked = false;
                }
                editar.combo_ciudad.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (bool.Parse(tipoAlojamiento) == true)
                {
                    editar.campo_precioxpersona.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[11].Value.ToString();
                    editar.LHabitaciones.Visible = false;
                    editar.habitacionesText.Visible = false;
                    editar.LDiaOPer.Visible = false;
                    editar.precioxdiaText.Visible = false;
                    editar.LBanios.Visible = false;
                    editar.baniosText.Visible = false;
                }
                else
                {
                    editar.labelprexpersona.Visible = false;
                    editar.campo_precioxpersona.Visible = false;
                    editar.habitacionesText.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[9].Value.ToString();
                    editar.precioxdiaText.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[10].Value.ToString();
                    editar.baniosText.Text = this.dataGridViewReservas.Rows[e.RowIndex].Cells[12].Value.ToString();
                }

                editar.Show();
            }*/

        }
    }
}
