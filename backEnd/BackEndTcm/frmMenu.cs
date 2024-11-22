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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnCadastroCli_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cliente = new frmCadastrarCliente();
            cliente.Show();
            this.Hide();
        }

        private void btnConsultaCli_Click(object sender, EventArgs e)
        {
            frmConsultarCliente consCliente = new frmConsultarCliente();
            consCliente.Show();
            this.Hide();
        }

        private void btnCadastroLoja_Click(object sender, EventArgs e)
        {
          
        }

        private void btnConsultaLoja_Click(object sender, EventArgs e)
        {
            
        }
    }
}
