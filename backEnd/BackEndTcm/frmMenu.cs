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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmAtualizar atualizar = new frmAtualizar();
            atualizar.Show();
            this.Hide();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente consCliente = new frmConsultarCliente();
          
            consCliente.Show();
            
        }

        private void eDITARCADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cliente = new frmCadastrarCliente();
          
            cliente.Show();
            
        }

        private void aTUALIZARCADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizar atualizar = new frmAtualizar();
          
            atualizar.Show();
            
        }

        private void fIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci fibonacci = new frmFibonacci();
          
            fibonacci.Show();
            
        }

        private void mÊSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMes mes = new frmMes();
            mes.Show();
            
        }

        private void fUTEBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFutebol futebol = new frmFutebol();
           
            futebol.Show();
            
        }

        private void mENOREMAIORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaiorMenor maiorMenor = new frmMaiorMenor();
           
            maiorMenor.Show();
            
        }

        private void fATORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFatorial fatorial = new frmFatorial();
            fatorial.Show();
           
        }

        private void uTILITÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
