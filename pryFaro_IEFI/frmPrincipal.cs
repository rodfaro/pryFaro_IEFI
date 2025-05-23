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
        clsUsuariosReg _user;
        int _tiempoTrabajoSeg = 0;

        public frmPrincipal(clsUsuariosReg user)
        {
            InitializeComponent();
            _user = user;
        }

        #region Metodos del Timer y frmPrincipal internas
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUser.Text = _user.Usuario;
            Timer.Start();
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Timer.Stop();   
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Tiempo trabajado
            _tiempoTrabajoSeg++;
            lblTiempoPrueba.Text = _tiempoTrabajoSeg.ToString();

            //Muestra la fecha
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy HH:mm");
        }
        #endregion

        #region VENTANAS 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int minTrabajados = (int)Math.Round((double)_tiempoTrabajoSeg / 60);

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
        #endregion
    }
}
