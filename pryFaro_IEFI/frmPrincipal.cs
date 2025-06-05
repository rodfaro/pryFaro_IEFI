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
    public partial class frmPrincipal : Form
    {
       
        //En el constructor recibe el usuario que se cargó en el LogIn con todo los datos(nombre, si es admin, etc)
        //Y ese usuario se va pasando a todo las ventanas para saber con que user se esta trabajando,
        public frmPrincipal(clsUsuariosReg user)
        {
            InitializeComponent();
            _user = user;
        }
        clsUsuariosReg _user;
        int _tiempoTrabajoSeg = 0;

        #region Metodos del Timer y frmPrincipal internas
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (_user.Admin == true)
            {
                administracionToolStripMenuItem.Enabled = true;
                administracionToolStripMenuItem.Visible = true;
            }
            else
            {
                administracionToolStripMenuItem.Enabled = false;
                administracionToolStripMenuItem.Visible = false;
            }
            lblUser.Text = _user.Usuario;
            Timer.Start();
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timer.Stop();
            Application.Exit();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Tiempo trabajado
            _tiempoTrabajoSeg++;
            lblTiempoPrueba.Text = $"{_tiempoTrabajoSeg.ToString()}s";

            //Muestra la fecha
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy HH:mm");
        }
        #endregion

        #region VENTANAS 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Redondea los segundos a minutos para guardarlos en la BD
            int minTrabajados = (int)Math.Round((double)_tiempoTrabajoSeg / 60);

            //Se carga todo los datos de la auditoria(user actual,  mins  trabajados) y los manda al frmSalir para agregar la descripcion y guardarlo.
            clsAuditar auditaroria = new clsAuditar();
            auditaroria.IdUsuario = _user.idUser;
            auditaroria.TiempoTrabajado = minTrabajados;

            frmSalir ventana = new frmSalir(auditaroria);
            ventana.ShowDialog();

        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_user.Admin == true)
            {
                frmAdministrarUsuarios ventana = new frmAdministrarUsuarios(_user);
                ventana.ShowDialog();
            }else MessageBox.Show($"El usuario: '{_user.Usuario}' NO tiene permisos de Administrador", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria ventana = new frmAuditoria();
            ventana.ShowDialog();
        }
        

        private void registrarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarTarea ventana = new frmRegistrarTarea(_user);
            ventana.ShowDialog();
        }

        private void visualizarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisulizarTareas ventanas = new frmVisulizarTareas();
            ventanas.ShowDialog();
        }
        #endregion

    }
}
