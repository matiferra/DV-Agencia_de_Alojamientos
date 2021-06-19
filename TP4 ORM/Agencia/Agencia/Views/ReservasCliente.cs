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

        //Bussines.AgenciaManager Ag = new Bussines.AgenciaManager();
        public ReservasCliente()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
            RefresVista();
        }

        public void RefresVista()
        {
            dataGridViewReservas.Rows.Clear();
            //string dni = Ag.recuperoDni(Global.GlobalSessionNombre, Global.GlobalSessionPass);
            //DataSet Lista = Ag.getReservasPorCliente(dni);
            int index = 0;
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

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if

        }
*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(desdeFecha.Text) && !string.IsNullOrEmpty(hastaFecha.Text))
            {
                dataGridViewReservas.Rows.Clear();

               /* string dni = Ag.recuperoDni(Global.GlobalSessionNombre, Global.GlobalSessionPass);
                DataSet Lista = Ag.buscarReservas(dni, desdeFecha.Text, hastaFecha.Text);

                int index = 0;
                if (Lista.Tables[0] != null && Lista.Tables[0].Rows.Count > 0)
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
            }
            else
            {
                MessageBox.Show("el campo tipo es requerido");
            }
        */
                }
        }

        private void dataGridViewReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dataGridViewReservas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult dr = MessageBox.Show("Seguro que deseea eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.dataGridViewReservas.Rows[e.RowIndex].Cells[6].Value.ToString());
                    /*if (Ag.eliminarReserva(id))
                    {
                        MessageBox.Show("RESERVA ELIMINADA");
                    }*/
                    RefresVista();

                }
            }
        }
    }
}
