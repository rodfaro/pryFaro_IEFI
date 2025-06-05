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
    public partial class frmRegistrarTarea : Form
    {
        List<clsTareas> lstTareas = new List<clsTareas>();
        clsConexion conexion = new clsConexion();
        clsUsuariosReg _userActual = new clsUsuariosReg();

        public frmRegistrarTarea(clsUsuariosReg user)
        {
            InitializeComponent();
            _userActual = user;
        }

        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            GrillaEstilizado();

            cmbLugar.SelectedIndex = 0;
            cmbTarea.SelectedIndex = 0;
            dtpFecha.MaxDate = DateTime.Now.Date;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Si la lista tiene por lo menos 1 elemento se pasa la Lista al metodo y lo guarda a cada uno
            //gracias a un foreach que recorre cada elemento.
            if (lstTareas.Count > 0)
            {
                conexion.GuardarTareas(lstTareas);

                lstTareas.Clear();
                LimpiarControladores();
                dgvTareas.Rows.Clear();
            }
            else MessageBox.Show("Necesitas tener al menos 1 elemento en la lista para agregarlo", "Listas vacia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btnAgregarLista_Click(object sender, EventArgs e)
        {

            //Se instancia un objeto tarea que se rellana con todo los datos seleccionados y se agrega a una lista.
            clsTareas tarea = new clsTareas();
            
            tarea.IdUsuario = _userActual.idUser;

            tarea.Tarea = cmbTarea.SelectedItem.ToString();
            tarea.Lugar = cmbLugar.SelectedItem.ToString();
            tarea.Fecha = dtpFecha.Value.Date;

            //Detalles
            tarea.UniformeInsumo = chkbxInsumo.Checked;
            tarea.LicenciaEstudio = chkbxEstudio.Checked;
            tarea.LicenciaVacacion = chkbxVacacion.Checked;
            tarea.LicenciaMedica = chkbxMedica.Checked;
            tarea.LicenciaPersonal = chkbxPersonal.Checked;
            tarea.ReclamoSalario = chkbxSalario.Checked;
            tarea.ReclamoRecibo = chkbxRecibo.Checked;
            tarea.HsExtra = chkbxHsExtra.Checked;
            tarea.Ausencia = chkbxAusencia.Checked;
            tarea.PermisoTemporal = chkbxPermiso.Checked;
            tarea.Retraso = chkbxRetraso.Checked;
            
            tarea.Comentario = txtComentario.Text;

            
            if (tarea != null)
            {
                //Se agrega a la lista el elemento y luego con un foreach en el metodo GuardarTareas se cargan todas a la BD.
                lstTareas.Add(tarea);
                ListarGrilla(tarea);

                LimpiarControladores();

            }
            else MessageBox.Show("Los campos no estan todos completos", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lstTareas.Clear();
            dgvTareas.Rows.Clear();
        }

        #region Controladores, Listado y Estilizados

        private void ListarGrilla(clsTareas tarea)
        {
            dgvTareas.RowTemplate.Height = 45;
            dgvTareas.ColumnHeadersHeight = 45;

            dgvTareas.Rows.Add(_userActual.Usuario, tarea.Tarea, tarea.Lugar, tarea.Fecha.ToString("dd/MM/yy"));

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
            dgvTareas.Columns["IdUsuario"].HeaderText = "Usuario";
            dgvTareas.Columns["Tarea"].HeaderText = "Tarea";
            dgvTareas.Columns["Fecha"].HeaderText = "Fecha";
            dgvTareas.Columns["Lugar"].HeaderText = "Lugar";

            // Ajustar ancho de columnas
            dgvTareas.Columns["Tarea"].Width = 170; // ancho mayor para Descripcion
            dgvTareas.Columns["Tarea"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            foreach (DataGridViewColumn col in dgvTareas.Columns)
            {
                if (col.Name != "Tarea")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControladores();
        }

        private void LimpiarControladores()
        {
            cmbLugar.SelectedIndex = 0;
            cmbTarea.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now.Date;

            chkbxInsumo.Checked = false;
            chkbxEstudio.Checked = false;
            chkbxVacacion.Checked = false;
            chkbxMedica.Checked = false;
            chkbxPersonal.Checked = false;
            chkbxSalario.Checked = false;
            chkbxRecibo.Checked = false;
            chkbxHsExtra.Checked = false;
            chkbxAusencia.Checked = false;
            chkbxPermiso.Checked = false;
            chkbxRetraso.Checked = false;

            txtComentario.Text = string.Empty;
        }

        #endregion
    }
}
