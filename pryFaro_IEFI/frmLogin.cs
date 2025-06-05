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

            clsUsuariosReg returnUsuario = conn.IniciarSesion(usuario);

            //Si el idUsuario sigue siendo -1 significa que no encontro ningun user con esos datos.
            if (returnUsuario.idUser != -1)
            {
                this.Hide();
                frmPrincipal ventana = new frmPrincipal(returnUsuario);
               
                ventana.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK);
            }
        }

        //Controla todo los txt y que caracteres se ingresan en los inputs.
        #region Controladores
        private void Controlador()
        {
            if (txtPassw.Text != string.Empty && txtUsuario.Text != string.Empty)
            {
                btnIniciarSesion.Enabled = true;
            }
            else btnIniciarSesion.Enabled = false;
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }

        private void txtPassw_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }
     

        private void txtPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        #endregion
    }
}
