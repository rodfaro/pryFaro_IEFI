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
            //Verifica que no exista ese usuario
            //Crea el usuario
            clsUsuariosReg usuario = new clsUsuariosReg();
            usuario.Usuario = txtUsuario.Text;
            usuario.Passw = txtPassw.Text;
            if (cmbAdmin.SelectedIndex == 0)
                usuario.Admin = true;
            else usuario.Admin = false;

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
        }
        private void Controlador()
        {
            if (txtUsuario.Text != string.Empty && txtPassw.Text != string.Empty)
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
        #endregion
    }
}
