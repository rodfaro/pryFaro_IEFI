using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryFaro_IEFI.Models;

namespace pryFaro_IEFI
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        clsConexion clsConexion = new clsConexion();

        private void btnCrear_Click(object sender, EventArgs e)
        {
           
            //Se instancia un usuario y se le rellena todo los datos para después crearlo.
            clsUsuariosReg usuario = new clsUsuariosReg();
            usuario.Usuario = txtUsuario.Text.Trim();
            usuario.Passw = txtPassw.Text.Trim();
            usuario.Nombre = txtNombre.Text.Trim();
            usuario.Celular = txtCelular.Text.Trim();
            usuario.Direccion = txtDireccion.Text.Trim();
            if (cmbAdmin.SelectedIndex == 0)
                usuario.Admin = true;
            else usuario.Admin = false;

            //Verifica que no exista ese usuario
            bool usuarioExiste = clsConexion.VerificarUsuarioExistente(usuario);
            if (usuarioExiste == false)
            {
                clsConexion.CrearUsuario(usuario);

                DialogResult result = MessageBox.Show("El usuario fue CREADO existosamente", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    this.Close();
            }
            else MessageBox.Show("El nombre de USUARIO ya EXISTE, intente otro", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        #region Controladores y boton Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void Vaciar()
        {
            txtPassw.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cmbAdmin.SelectedIndex = 1;
            txtCelular.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
        private void Controlador()
        {
            if (txtUsuario.Text != string.Empty && txtPassw.Text != string.Empty &&
                txtCelular.Text != string.Empty && txtDireccion.Text != string.Empty && txtNombre.Text != string.Empty)
                btnCrear.Enabled = true;
            else btnCrear.Enabled = false;
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            cmbAdmin.SelectedIndex = 1;
        }

        private void txtPassw_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            Controlador();
        }
        #endregion
    }
}
