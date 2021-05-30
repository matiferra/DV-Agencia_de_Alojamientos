using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussines;
using System.IO;

namespace Agencia.Views
{
    public partial class ResultadoBusqueda : Form
    {

        static Bussines.Agencia a = new Bussines.Agencia();

        public ResultadoBusqueda()
        {
            InitializeComponent();
        }

        Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
