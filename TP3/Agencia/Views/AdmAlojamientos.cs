using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bussines;

namespace Agencia.Views
{
    public partial class AdmAlojamientos : Form
    {

        AgenciaManager Ag = new AgenciaManager();
        public AgenciaManager agencia { get; set; }

        public AdmAlojamientos()
        {
            InitializeComponent();
            combo_ciudadHeader.DisplayMember = "nombre";
            combo_ciudadHeader.ValueMember = "id_ciudad";
            combo_ciudadHeader.DataSource = Ag.getCiudades();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
            RefresVista();

        }
        public void RefresVista()
        {
            alojamientosGrid.Rows.Clear();
            DataSet Lista = Ag.obtenerAlojamientos();
            int index = 0;
            if (Lista.Tables[0] != null && Lista.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in Lista.Tables[0].Rows)
                {
                    alojamientosGrid.Rows.Add();
                    alojamientosGrid.Rows[index].Cells[2].Value = dr["id_alojamiento"].ToString();
                    alojamientosGrid.Rows[index].Cells[3].Value = dr["barrio"].ToString();
                    alojamientosGrid.Rows[index].Cells[4].Value = int.Parse(dr["estrellas"].ToString());
                    alojamientosGrid.Rows[index].Cells[5].Value = dr["cantidadDePersonas"].ToString();
                    alojamientosGrid.Rows[index].Cells[6].Value = dr["tv"].ToString();
                    alojamientosGrid.Rows[index].Cells[7].Value = dr["eshotel"].ToString();
                    alojamientosGrid.Rows[index].Cells[8].Value = dr["id_ciudad"].ToString();
                    alojamientosGrid.Rows[index].Cells[9].Value = dr["cantidad_de_habitaciones"].ToString();
                    alojamientosGrid.Rows[index].Cells[10].Value = dr["precio_por_dia"].ToString();
                    alojamientosGrid.Rows[index].Cells[11].Value = dr["precio_por_persona"].ToString();
                    alojamientosGrid.Rows[index].Cells[12].Value = dr["cantidadDeBanios"].ToString();

                    index++;

                }
            }
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void AdmAlojamientos_Load(object sender, EventArgs e)
        {
            precioText.Visible = false;
            personasText.Visible = false;
            LBaños.Visible = false;
            LHabitaciones.Visible = false;
            LDiaOPer.Visible = false;
            LPersonas.Visible = false;
            habitacionesText.Visible = false;
            baniosText.Visible = false;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }



        private void AdmAlojamientos_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selec = tipoAlojamientoCombo.SelectedItem.ToString();


            if (selec == "Cabaña")
            {
                LBaños.Visible = true;
                LHabitaciones.Visible = true;
                baniosText.Visible = true;
                habitacionesText.Visible = true;
                LDiaOPer.Text = "Precio por dia";
                LPersonas.Visible = true;
                precioText.Visible = true;
                personasText.Visible = true;
            }
            else if (selec == "Hotel")
            {
                LBaños.Visible = false;
                LHabitaciones.Visible = false;
                baniosText.Visible = false;
                habitacionesText.Visible = false;
                LDiaOPer.Text = "Precio por persona";
                LPersonas.Visible = true;
                LDiaOPer.Visible = true;
                precioText.Visible = true;
                personasText.Visible = true;

            }

        }

        public void limpioEncabezado()
        {
            estrellasText.Text = "";
            personasText.Text = "";
            barrioText.Text = "";
            precioText.Text = "";
            habitacionesText.Text = "";
            baniosText.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (check_tv.Checked)
            //{
            //    tv = "true";
            //}
            //else
            //{
            //    tv = "false";
            //}
            //ciudad = combo_ciudadHeader.Text;
            //barrio = barrioText.Text;
            //estrellas = estrellasText.Text;
            //tipoAlojamiento = tipoAlojamientoCombo.Text;
            //personas = personasText.Text;
            //precio = precioText.Text;
            //habitaciones = habitacionesText.Text;
            //banios = baniosText.Text;


            //string[] datos = { tipoAlojamiento, ciudad, barrio, estrellas, personas, tv, precio, habitaciones, banios, " " };
            //if (!File.Exists(sourceFile))
            //{
            //    File.WriteAllLines(sourceFile, datos);
            //}
            //else
            //{
            //    foreach (var item in datos)
            //    {
            //        File.AppendAllText(sourceFile, item + Environment.NewLine);
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //alojamientosGrid.Rows.Clear();
            //foreach (List<string> alojamiento in agencia.obtenerAlojamientos())
            //{
            //    alojamientosGrid.Rows.Add(alojamiento.ToArray());
            //}
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (Ag.agregarAlojamiento(tipoAlojamientoCombo.Text, combo_ciudadHeader.SelectedValue.ToString(), barrioText.Text, estrellasText.Text,
                                  personasText.Text, check_tv.Checked, precioText.Text, habitacionesText.Text, baniosText.Text))
            {

                MessageBox.Show("Agregado con éxito");              
                limpioEncabezado();
                RefresVista();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el alojamiento");
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tvSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void edit_aloj_UpdateHadler(object sender, EditarAlojamiento.UpdateEventArgs args)
        {
            RefresVista();
        }

        private void alojamientosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.alojamientosGrid.Columns[e.ColumnIndex].Name == "Eliminar_aloja")
            {
                DialogResult dr = MessageBox.Show("Seguro que deseea eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    var id = this.alojamientosGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Ag.quitarAlojamiento(int.Parse(id));
                    RefresVista();

                }

            }
            else if (this.alojamientosGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                var tipoAlojamiento = this.alojamientosGrid.Rows[e.RowIndex].Cells[7].Value.ToString();

                EditarAlojamiento editar = new EditarAlojamiento(this);
                editar.UpdateEventArgsHandler += edit_aloj_UpdateHadler; //  metodo la cual me permite actualizar la grilla cuando termine de guardar los cambios

                editar.id_text.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                editar.id_text.ReadOnly = true;
                editar.id_text.Visible = false;
                editar.label_id.Visible = false;
                editar.barrioText.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                editar.estrellasText.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                editar.personasText.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (this.alojamientosGrid.Rows[e.RowIndex].Cells[6].Value.ToString() == "si")
                {
                    editar.check_tv.Checked = true;
                }
                else
                {
                    editar.check_tv.Checked = false;
                }
                editar.combo_ciudad.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (bool.Parse(tipoAlojamiento) == true)
                {
                    editar.campo_precioxpersona.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[11].Value.ToString();
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
                    editar.habitacionesText.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                    editar.precioxdiaText.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
                    editar.baniosText.Text = this.alojamientosGrid.Rows[e.RowIndex].Cells[12].Value.ToString();
                }

                editar.Show();
            }





        }


    }
}
