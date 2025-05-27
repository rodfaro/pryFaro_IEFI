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
    public partial class frmEditarUsuario : Form
    {
        private clsUsuariosReg _user;
        private DataGridView _dgvUsers;
        //Para evitar que edite o elimine el usuario con el que esta actualmente trabajando pasandole el user a cada ventana.

        clsConexion conn = new clsConexion();

        public frmEditarUsuario(clsUsuariosReg usuario, DataGridView dgvUsuarios)
        {
            InitializeComponent();
            _user = usuario;
            _dgvUsers = dgvUsuarios;
        }
        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            txtId.Text = _user.idUser.ToString();
            txtUsuario.Text = _user.Usuario;
            txtPassw.Text = _user.Passw;
            txtNombre.Text = _user.Nombre;
            txtDireccion.Text = _user.Direccion;
            txtCelular.Text = _user.Celular;
            if (_user.Admin == true)
                cmbAdmin.SelectedIndex = 0;
            else if (_user.Admin == false)
                cmbAdmin.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _user.idUser = int.Parse(txtId.Text.Trim());
            _user.Usuario = txtUsuario.Text.Trim();
            _user.Passw = txtPassw.Text.Trim();
            _user.Nombre = txtNombre.Text.Trim();
            _user.Celular = txtCelular.Text.Trim();
            _user.Direccion = txtDireccion.Text.Trim();
            if (cmbAdmin.SelectedIndex == 0)
                _user.Admin = true;
            else if (cmbAdmin.SelectedIndex == 1)
                _user.Admin = false;

            //Verificar usuario existente
            bool usuarioExistente = conn.VerificarUsuarioExistente(_user);
            if (usuarioExistente == false) // se puede crear
            {
                conn.EditarUsuario(_user);

                DialogResult result = new DialogResult();
                result = MessageBox.Show("Usuario editado correctamente", "Usuario Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else MessageBox.Show("El nombre de USUARIO ya EXISTE o está en USO, intente otro", "Usuario existente o en uso", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region Controladores

        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtPassw.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cmbAdmin.SelectedIndex = 1;
            txtDireccion.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void Controlador()
        {
            if (txtPassw.Text != string.Empty && txtUsuario.Text != string.Empty)
            {
                btnEditar.Enabled = true;
            } else btnEditar.Enabled = false;
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
    }
}
