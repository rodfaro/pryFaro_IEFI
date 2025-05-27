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
        private clsUsuariosReg _actualUser;
        private DataTable _dtGlobal;
        clsConexion clsConexion = new clsConexion();
        private bool botonesAgregados = false;


        public frmAdministrarUsuarios(clsUsuariosReg user)
        {
            InitializeComponent();
            _actualUser = user;
        }

        private void frmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            Listar();            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(_dtGlobal);
            dv.RowFilter = $"Usuario LIKE '{txtSearch.Text}%'";
            dgvUsers.DataSource= dv;
        }
        
        private void GrillaEstilizado()
        {
            // General
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;

            // Fuente general (celdas)
            dgvUsers.DefaultCellStyle.Font = new Font("Nirmala UI", 12, FontStyle.Regular);
            dgvUsers.DefaultCellStyle.ForeColor = Color.Black;
            dgvUsers.DefaultCellStyle.BackColor = Color.White;
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Encabezados
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 15, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Bordes
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Estilo de filas alternas
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Cambiar los nombres de las columnas
            dgvUsers.Columns["idUsuario"].HeaderText = "Id";
            dgvUsers.Columns["Usuario"].HeaderText = "Usuario";
            dgvUsers.Columns["Passw"].HeaderText = "Contraseña";
            dgvUsers.Columns["Admin"].HeaderText = "Administrador";

            // Primero verificamos que no exista para no duplicar botones
            if (!botonesAgregados)
            {
                // EDITAR
                var btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                btnEditar.Width = 70;

                // Estilo del botón
                var editarCell = (DataGridViewButtonCell)btnEditar.CellTemplate;
                editarCell.Style.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
                editarCell.Style.BackColor = Color.LightSteelBlue;
                editarCell.Style.ForeColor = Color.Black;
                editarCell.Style.SelectionBackColor = Color.SteelBlue;
                editarCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;      // <-- centra el botón
                btnEditar.DefaultCellStyle = editarCell.Style;

                // Encabezado centrado (opcional)
                btnEditar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUsers.Columns.Add(btnEditar);

                // ELIMINAR
                var btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.Width = 70;

                var eliminarCell = (DataGridViewButtonCell)btnEliminar.CellTemplate;
                eliminarCell.Style.Font = new Font("Nirmala UI", 11, FontStyle.Bold);
                eliminarCell.Style.BackColor = Color.LightCoral;
                eliminarCell.Style.ForeColor = Color.White;
                eliminarCell.Style.SelectionBackColor = Color.IndianRed;
                eliminarCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;    // <-- centra el botón
                btnEliminar.DefaultCellStyle = eliminarCell.Style;

                // Encabezado centrado (opcional)
                btnEliminar.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUsers.Columns.Add(btnEliminar);

                botonesAgregados = true;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearUsuario ventana = new frmCrearUsuario();
            ventana.ShowDialog();

            Listar();
        }
        private void Listar()
        {
            dgvUsers.RowTemplate.Height = 45;
            dgvUsers.ColumnHeadersHeight = 45;

            _dtGlobal = clsConexion.Listar("Usuarios");
            dgvUsers.DataSource = _dtGlobal;

            GrillaEstilizado();

        }
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvUsers.Columns["btnEditar"].Index)
            {
                clsUsuariosReg usuarioNuevo = new clsUsuariosReg();
                usuarioNuevo.idUser = (int)dgvUsers.Rows[e.RowIndex].Cells["idUsuario"].Value;
                usuarioNuevo.Usuario = dgvUsers.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                usuarioNuevo.Passw = dgvUsers.Rows[e.RowIndex].Cells["Passw"].Value.ToString();
                usuarioNuevo.Admin = (bool)dgvUsers.Rows[e.RowIndex].Cells["Admin"].Value;
                usuarioNuevo.Nombre = dgvUsers.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                usuarioNuevo.Direccion = dgvUsers.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                usuarioNuevo.Celular = dgvUsers.Rows[e.RowIndex].Cells["Celular"].Value.ToString();

                if (_actualUser.idUser != usuarioNuevo.idUser)
                {
                    frmEditarUsuario ventana = new frmEditarUsuario(usuarioNuevo, dgvUsers);
                    ventana.ShowDialog();

                    Listar();
                }
                else MessageBox.Show("NO puedes EDITAR tu PROPIO USUARIO ESTANDO EN USO", "Usuario en uso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            //Eliminar
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvUsers.Columns["btnEliminar"].Index)
            {
                // Obtener el Id del usuario o clave primaria para cargar los datos
                clsUsuariosReg usuarioEliminar = new clsUsuariosReg();
                usuarioEliminar.idUser = (int)dgvUsers.Rows[e.RowIndex].Cells["idUsuario"].Value;
                usuarioEliminar.Usuario = dgvUsers.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();

                if (_actualUser.idUser != usuarioEliminar.idUser)
                {
                    //verificamos que no tenga auditorias/logins asociados por FK

                    bool usuarioConAuditorias = clsConexion.VerificarUsuarioConAuditorias(usuarioEliminar);

                    if (usuarioConAuditorias == false)
                    {
                        DialogResult result = MessageBox.Show($"Estas seguro que quieres ELIMINAR el usuario '{usuarioEliminar.Usuario.ToUpper()}'", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            //carga los datos faltates del usuario a eliminar
                            usuarioEliminar.Passw = dgvUsers.Rows[e.RowIndex].Cells["Passw"].Value.ToString();
                            usuarioEliminar.Admin = (bool)dgvUsers.Rows[e.RowIndex].Cells["Admin"].Value;

                            clsConexion.EliminarUsuario(usuarioEliminar);
                            Listar();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("El usuario que intentas ELIMINAR TIENE AUDITORIAS, ¿ESTÁS SEGURO QUE QUIERES ELIMINAR EL USUARIO Y TODAS LAS AUDITORIAS RELACIONADAS A ÉL?", "Usuario con Auditorias", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes) 
                        {
                            //Borramos auditorias primero y dps le pasamos el usuario con el id
                            clsConexion.EliminarAuditorias(usuarioEliminar);

                            //Luego borramos el usuario finalmente
                            clsConexion.EliminarUsuario(usuarioEliminar);
                            Listar();
                        }
                        
                    }
                }
                else MessageBox.Show("NO puedes ELIMINAR tu PROPIO USUARIO ESTANDO EN USO", "Usuario en uso", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

    }
}
