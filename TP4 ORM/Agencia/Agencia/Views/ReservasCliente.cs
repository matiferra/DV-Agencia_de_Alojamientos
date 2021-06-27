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
    public partial class ReservasCliente : Form
    {

        Bussines.AgenciaManager Ag = new Bussines.AgenciaManager();
        public ReservasCliente()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
            RefresVista();
        }

        public void RefresVista()
        {
           
            dataGridViewReservas.Rows.Clear();
            List<List<string>> reservas = Ag.getTodasLasReservasCliente(); 

            foreach (List<string> lista in reservas)
                dataGridViewReservas.Rows.Add(lista.ToArray());

            //string dni = Ag.recuperoDni(Global.GlobalSessionNombre, Global.GlobalSessionPass);
            //DataSet Lista = Ag.getReservasPorCliente(dni);
           /* if (Lista.Tables[0] != null && Lista.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in Lista.Tables[0].Rows)
                {
                    dataGridViewReservas.Rows.Add();
                    dataGridViewReservas.Rows[index].Cells[1].Value = dr["fhasta"].ToString();
                    dataGridViewReservas.Rows[index].Cells[2].Value = dr["fdesde"].ToString();
                    dataGridViewReservas.Rows[index].Cells[3].Value = dr["ciudad"].ToString();
                    dataGridViewReservas.Rows[index].Cells[4].Value = dr["precio"].ToString();
                    dataGridViewReservas.Rows[index].Cells[5].Value = dr["alojamiento"].ToString();
                    dataGridViewReservas.Rows[index].Cells[6].Value = dr["id_reserva"].ToString();
                    index++;

                }
            }
        */
            }


        private void ReservasCliente_Load(object sender, EventArgs e)
        {

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
                    } else
                    {
                        MessageBox.Show("Segui participando");
                    }
                    RefresVista();

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
