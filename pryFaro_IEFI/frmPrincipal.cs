using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFaro_IEFI
{
    public partial class frmPrincipal : Form
    {
        string _user;
        public frmPrincipal(string user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUser.Text = _user;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
