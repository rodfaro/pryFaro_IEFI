using pryFaro_IEFI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFaro_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsConexion conn = new clsConexion();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            clsUsuariosReg usuario = new clsUsuariosReg();
            usuario.Usuario = txtUsuario.Text;
            usuario.Passw = txtPassw.Text;

            int resultado = conn.IniciarSesion(usuario);

            if (resultado >= 1)
            {
                //ABRE EL OTRO FORM

                string user = usuario.Usuario;
                this.Hide();
                frmPrincipal ventana = new frmPrincipal(user);
               
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK);
            }
        }


    }
}
