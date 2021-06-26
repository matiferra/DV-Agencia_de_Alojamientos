using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agencia.Views

{
    public partial class AdmUsuarios : Form
    {
        //static Bussines.Agencia a = new Bussines.Agencia();
        private Bussines.AgenciaManager ag = new Bussines.AgenciaManager();
        // Usuario usuario = null;

        private Form currentChildForm;

        public AdmUsuarios()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);
            RefresVista();
            dataGridViewUsuarios.Columns[2].DefaultCellStyle.BackColor = Color.Red;

        }

        public void RefresVista()
        {
            Bussines.AgenciaManager agc = new Bussines.AgenciaManager();
            dataGridViewUsuarios.Rows.Clear();
            List<List<string>> lista = new List<List<string>>();
            lista = agc.obtenerUsuarios();
            foreach (List<string> usuario in lista)
                dataGridViewUsuarios.Rows.Add(usuario.ToArray());

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

        private void edit_usuario_UpdateHadler(object sender, EditarUsuario.UpdateEventArgs args)
        {
            RefresVista();
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "boton_eliminar")
            {
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    var id = this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    ag.eliminarUsuario(int.Parse(id));
                    RefresVista();
                }

            }
            else if (this.dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "boton_Editar")
            {
                EditarUsuario editar = new EditarUsuario(this);
                editar.UpdateEventArgsHandler += edit_usuario_UpdateHadler; //  metodo la cual me permite actualizar la grilla cuando termine de guardar los cambios

                editar.text_nombre.Text = this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                editar.textBox_contras.Text = this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                editar.textBox_dni.Text = this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString(); // dni lo tomamos como pk de la tabla no es valido poder modificarlo
                editar.textBox_mail.Text = this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                editar.check_esadmin.Checked = bool.Parse(this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString());

                editar.Show();
            }
            else if (this.dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "boton_desbloquear")
            {
                DialogResult dr = MessageBox.Show("Seguro que desea Desbloquear?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString());
                    bool esBloqueado = bool.Parse(this.dataGridViewUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString());
                    ag.desbloquearUsuario(id, esBloqueado);
                    RefresVista();
                }

            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            dataGridViewUsuarios.Rows.Clear();

            //List<Entities.Usuario> Lista = ag.buscarUsuario(12345678);



            //int index = 0;

            //    foreach (var dr in Lista)
            //    {
            //    dataGridViewUsuarios.Rows.Add();
            //    dataGridViewUsuarios.Rows[index].Cells[3].Value = dr.DNI;
            //    dataGridViewUsuarios.Rows[index].Cells[4].Value = dr.mail;
            //    dataGridViewUsuarios.Rows[index].Cells[5].Value = dr.bloqueado;
            //    dataGridViewUsuarios.Rows[index].Cells[6].Value = dr.nombre;
            //    dataGridViewUsuarios.Rows[index].Cells[7].Value = dr.esAdmin;
            //    dataGridViewUsuarios.Rows[index].Cells[8].Value = dr.pass;

            //    index++;

            //    }



        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void dataGridViewUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}



        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}



        //private void desbloquearButton_Click(object sender, EventArgs e)
        //{

        //    //TODO
        //   /* foreach (var item in ag.misUsuarios)
        //    {
        //        if (usuarioEnMemoria.DNI == item.DNI)
        //        {
        //            ag.desbloquearUsuario(item.DNI);
        //        }
        //    }*/
        //}


        //private void editarButton_Click(object sender, EventArgs e)
        //{

        //}

        //private void eliminarButton_Click(object sender, EventArgs e)
        //{

        //    //TODO
        // /*   foreach (var item in ag.misUsuarios)
        //    {
        //        if (usuarioEnMemoria.DNI == item.DNI)
        //        {
        //            ag.eliminarUsuario(item.DNI);
        //        }
        //    }
        // */
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

    }
}
