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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Admin" && txtSenha.Text == "cidade123")
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                MessageBox.Show("acesso ao sistema realizado!");
                this.Hide();
            }
        }
    }
}
