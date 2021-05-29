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
    public partial class Form1 : Form
    {
     
        

        private Login login;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new Login();
                login.MdiParent = this;
                login.FormClosed += new FormClosedEventHandler(cerrarLogin);
                login.Show();
            } else
            {
                login.Activate();
            }

        }




        public void cerrarLogin(object sender, FormClosedEventArgs e)
        {
            login = null;
        }

    }







}
