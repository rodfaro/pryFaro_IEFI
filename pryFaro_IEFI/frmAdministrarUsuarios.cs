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
    public partial class frmAdministrarUsuarios : Form
    {
        private clsUsuariosReg _user;
        private DataTable _dtGlobal;

        clsConexion conexion = new clsConexion();
        public frmAdministrarUsuarios(clsUsuariosReg user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            //Verifica permisos nuevamente
            if (_user.Admin == false)
            {
                MessageBox.Show($"El usuario '{_user.Usuario}' NO tiene permisos de ADMINISTRADOR", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
            else
            {
                string tabla = "Usuarios";
                _dtGlobal = conexion.Listar(tabla);
                dgvAdministrar.DataSource = _dtGlobal;
            }
        }
    }
}
