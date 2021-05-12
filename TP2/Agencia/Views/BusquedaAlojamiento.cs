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
        public BusquedaAlojamiento()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultadoBusqueda rb = new ResultadoBusqueda();
            rb.Show();
        }
    }
}
