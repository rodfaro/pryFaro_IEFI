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
    public partial class frmAuditoria : Form
    {
        private DataTable _dtGlobal;

        public frmAuditoria()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            _dtGlobal = conexion.Listar();
            dgvLogins.DataSource = _dtGlobal;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(_dtGlobal);
            dataView.RowFilter = $"Usuario LIKE '{txtSearch.Text}%'";
            dgvLogins.DataSource = dataView;
        }
    }
}
