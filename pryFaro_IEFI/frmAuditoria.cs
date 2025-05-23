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
            Listar();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(_dtGlobal);
            dataView.RowFilter = $"Usuario LIKE '{txtSearch.Text}%'";
            dgvLogins.DataSource = dataView;
        }

        private void Listar()
        {
            dgvLogins.RowTemplate.Height = 45;
            dgvLogins.ColumnHeadersHeight = 45;

            _dtGlobal = conexion.Listar();
            dgvLogins.DataSource = _dtGlobal;

            GrillaEstilizado();
        }

        private void GrillaEstilizado()
        {
            // General
            dgvLogins.EnableHeadersVisualStyles = false;
            dgvLogins.RowHeadersVisible = false;
            dgvLogins.AllowUserToAddRows = false;
            dgvLogins.AllowUserToDeleteRows = false;
            dgvLogins.ReadOnly = true;
            dgvLogins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogins.MultiSelect = false;
            dgvLogins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogins.BackgroundColor = Color.White;
            dgvLogins.BorderStyle = BorderStyle.None;

            // Fuente general (celdas)
            dgvLogins.DefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Regular);
            dgvLogins.DefaultCellStyle.ForeColor = Color.Black;
            dgvLogins.DefaultCellStyle.BackColor = Color.White;
            dgvLogins.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvLogins.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Encabezados
            dgvLogins.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 15, FontStyle.Bold);
            dgvLogins.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvLogins.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvLogins.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Bordes
            dgvLogins.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLogins.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Estilo de filas alternas
            dgvLogins.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Aumentar altura de las filas
            dgvLogins.RowTemplate.Height = 45; // Altura de fila
            dgvLogins.ColumnHeadersHeight = 45; // Altura de encabezado

            // Cambiar los nombres de las columnas
            dgvLogins.Columns["Id"].HeaderText = "ID";
            dgvLogins.Columns["TiempoTrabajado"].HeaderText = "Tiempo trabajado (min)";

            // Ajustar ancho de columnas
            dgvLogins.Columns["Descripcion"].Width = 570; // ancho mayor para Descripcion
            dgvLogins.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            foreach (DataGridViewColumn col in dgvLogins.Columns)
            {
                if (col.Name != "Descripcion")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
