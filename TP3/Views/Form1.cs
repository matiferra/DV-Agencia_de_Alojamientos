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
    public partial class Form1 : Form
    {
        static Bussines.Agencia agencia = new Bussines.Agencia();
        static Bussines.AgenciaManager agenciaManager = new Bussines.AgenciaManager(agencia);
        static Bussines.Usuario usuario = new Bussines.Usuario();
        public Form1()
        {
            InitializeComponent();
            AdmAlojamientos admAlojamientosForm = new AdmAlojamientos();
            admAlojamientosForm.MdiParent = this;
            AdmReservas admReservasForm = new AdmReservas();
            admReservasForm.MdiParent = this;
            AdmUsuarios admUsuarios = new AdmUsuarios();
            admUsuarios.MdiParent = this;
            Administrador adminForm = new Administrador(admUsuarios, admAlojamientosForm, admReservasForm, agenciaManager);
            adminForm.MdiParent = this;
            BusquedaAlojamiento busquedadAlojamientosForm = new BusquedaAlojamiento();
            busquedadAlojamientosForm.MdiParent = this;
            RecuperarContraseña cambiarContraseniasForm = new RecuperarContraseña();
            cambiarContraseniasForm.MdiParent = this;
            ResultadoBusqueda resultadoBusquedaForm = new ResultadoBusqueda();
            resultadoBusquedaForm.MdiParent = this;
            Cliente clienteForm = new Cliente(busquedadAlojamientosForm, cambiarContraseniasForm, resultadoBusquedaForm);
            clienteForm.MdiParent = this;
            RegistroUsuario registroUsuarioForm = new RegistroUsuario(agenciaManager);
            registroUsuarioForm.MdiParent = this;

            Login loginForm = new Login(adminForm, clienteForm, registroUsuarioForm, agenciaManager, usuario);
            loginForm.MdiParent = this;
            loginForm.Show();
        }

    }

}
