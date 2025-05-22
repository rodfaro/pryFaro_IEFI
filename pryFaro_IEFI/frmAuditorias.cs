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
    public partial class frmAuditorias : Form
    {
        public frmAuditorias()
        {
            InitializeComponent();
        }

        clsConexion clsConexion = new clsConexion();
        DataTable dtGlobal = new DataTable();

        private void frmAuditorias_Load(object sender, EventArgs e)
        {
            dtGlobal = clsConexion.Listar();
            dgvLogins.DataSource = dtGlobal;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtGlobal);
            dv.RowFilter = $"Usuario LIKE '{txtSearch.Text.Trim()}%'";
            dgvLogins.DataSource = dv;
        }
    }
}
