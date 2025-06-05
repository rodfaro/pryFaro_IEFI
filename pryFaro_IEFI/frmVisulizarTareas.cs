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
    public partial class frmVisulizarTareas : Form
    {
        public frmVisulizarTareas()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        DataTable _dtGlobal = new DataTable();
        private void frmVisulizarTareas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(_dtGlobal);
            dv.RowFilter = $"Usuario LIKE '{txtSearch.Text}%'";
            dgvTareas.DataSource = dv;
        }

        #region Grilla y estilizado
        private void Listar()
        {
            dgvTareas.RowTemplate.Height = 45;
            dgvTareas.ColumnHeadersHeight = 45;

            _dtGlobal = conexion.ListarTareas();
            dgvTareas.DataSource = _dtGlobal;

            GrillaEstilizado();
        }

        private void GrillaEstilizado()
        {
            // General
            dgvTareas.EnableHeadersVisualStyles = false;
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.ReadOnly = true;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.MultiSelect = false;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.BackgroundColor = Color.White;
            dgvTareas.BorderStyle = BorderStyle.None;

            // Fuente general (celdas)
            dgvTareas.DefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Regular);
            dgvTareas.DefaultCellStyle.ForeColor = Color.Black;
            dgvTareas.DefaultCellStyle.BackColor = Color.White;
            dgvTareas.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvTareas.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Encabezados
            dgvTareas.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 15, FontStyle.Bold);
            dgvTareas.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvTareas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvTareas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Bordes
            dgvTareas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTareas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Estilo de filas alternas
            dgvTareas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Aumentar altura de las filas
            dgvTareas.RowTemplate.Height = 45; // Altura de fila
            dgvTareas.ColumnHeadersHeight = 45; // Altura de encabezado

            // Cambiar los nombres de las columnas
            dgvTareas.Columns["Usuario"].HeaderText = "Usuario";
            dgvTareas.Columns["UniformeInsumo"].HeaderText = "Uniforme";
            dgvTareas.Columns["LicenciaEstudio"].HeaderText = "Licencia por Estudio";
            dgvTareas.Columns["LicenciaVacacion"].HeaderText = "Licencia por Vacacion";
            dgvTareas.Columns["LicenciaMedica"].HeaderText = "Licencia Médica";
            dgvTareas.Columns["LicenciaPersonal"].HeaderText = "Licencia Personal";
            dgvTareas.Columns["ReclamoSalario"].HeaderText = "Reclamo Salario";
            dgvTareas.Columns["ReclamoRecibo"].HeaderText = "Reclamo Recibo";
            dgvTareas.Columns["HsExtra"].HeaderText = "Horas extra";
            dgvTareas.Columns["Ausencia"].HeaderText = "Ausencia Justificada";
            dgvTareas.Columns["PermisoTemporal"].HeaderText = "Permiso Temporal";
            

            // Ajustar ancho de columnas
            dgvTareas.Columns["Comentario"].Width = 200; // ancho mayor para Descripcion
            dgvTareas.Columns["Comentario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            foreach (DataGridViewColumn col in dgvTareas.Columns)
            {
                if (col.Name != "Comentario")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        #endregion

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
