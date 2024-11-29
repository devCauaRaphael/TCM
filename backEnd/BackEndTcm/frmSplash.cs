using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEndTcm
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pgrSplash_Click(object sender, EventArgs e)
        {
            

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgrSplash.Value < 100)
            {
                pgrSplash.Value = pgrSplash.Value + 2;
            }
            else
            {
                tmrSplash.Enabled = false;
                this.Visible = false;
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
