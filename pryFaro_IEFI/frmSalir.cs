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
    public partial class frmSalir : Form
    {
        clsAuditar _auditoria;
        clsConexion conn = new clsConexion();

        public frmSalir(clsAuditar auditoria)
        {
            InitializeComponent();
            _auditoria = auditoria;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Guarda todo
            _auditoria.Descripcion = txtDesc.Text.Trim();

            conn.GuardarJornada(_auditoria);


            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc.Text != string.Empty)
            {
                btnSalir.Enabled = true;
            } else btnSalir.Enabled = false;
        }

        private void frmSalir_Load(object sender, EventArgs e)
        {

        }
    }
}
