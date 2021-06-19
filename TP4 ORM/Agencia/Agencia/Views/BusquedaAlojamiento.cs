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
    public partial class BusquedaAlojamiento : Form
    {
//        AgenciaManager Ag = new AgenciaManager();
        public BusquedaAlojamiento()
        {
            InitializeComponent();
            comboBox_ciudad.DisplayMember = "nombre";
            comboBox_ciudad.ValueMember = "id_ciudad";
           // comboBox_ciudad.DataSource = Ag.getCiudades();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* if (!string.IsNullOrEmpty(seleccion_tipo.Text))
            {
                dataGridView1.Rows.Clear();


               DataSet Lista = Ag.buscarAlojamientos(comboBox_ciudad.SelectedValue.ToString(), Pdesde_campo.Text,
                                         Phasta_campo.Text, text_cantidad.Text, seleccion_tipo.Text);

                int index = 0;
                if (Lista.Tables[0] != null && Lista.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in Lista.Tables[0].Rows)
                    {
                        dataGridView1.Rows.Add();
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.HeaderText = "Reservar";
                        btn.Text = "reservar";
                        btn.UseColumnTextForButtonValue = true;
                        
                        dataGridView1.Rows[index].Cells[0].Value = dr["barrio"].ToString();
                        dataGridView1.Rows[index].Cells[1].Value = int.Parse(dr["estrellas"].ToString());
                        dataGridView1.Rows[index].Cells[2].Value = dr["cantidadDePersonas"].ToString();
                        dataGridView1.Rows[index].Cells[3].Value = dr["tv"].ToString();                       
                        dataGridView1.Rows[index].Cells[4].Value = dr["id_ciudad"].ToString();
                        dataGridView1.Rows[index].Cells[5].Value = dr["cantidad_de_habitaciones"].ToString();
                        dataGridView1.Rows[index].Cells[6].Value = dr["precio_por_dia"].ToString();
                        dataGridView1.Rows[index].Cells[7].Value = dr["precio_por_persona"].ToString();
                        dataGridView1.Rows[index].Cells[8].Value = dr["cantidadDeBanios"].ToString();
                        //dataGridView1.Rows[index].Cells[9].Value = btn;
                        index++;

                    }
                }
            }
            else
            {
                MessageBox.Show("el campo tipo es requerido");
            }

            //this.Hide();
            //ResultadoBusqueda rb = new ResultadoBusqueda();
            // rb.Show();
        */
            }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BusquedaAlojamiento_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccion_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
