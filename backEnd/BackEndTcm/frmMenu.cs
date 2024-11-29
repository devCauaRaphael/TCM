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
            
        }

        private void btnConsultaCli_Click(object sender, EventArgs e)
        {
            frmConsultarCliente consCliente = new frmConsultarCliente();
            consCliente.MdiParent = this;
            consCliente.Show();
            
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
            
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente consCliente = new frmConsultarCliente();
            consCliente.MdiParent = this;
            consCliente.Show();
            
        }

        private void eDITARCADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* frmAtualizarProd atualizarProd = new frmAtualizarProd();
            atualizarProd.MdiParent = this;
            atualizarProd.Show();*/
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cliente = new frmCadastrarCliente();
            cliente.MdiParent = this;
            cliente.Show();
            
        }

        private void aTUALIZARCADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizar atualizar = new frmAtualizar();
            atualizar.MdiParent = this;
            atualizar.Show();
            
        }

        private void fIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci fibonacci = new frmFibonacci();
          fibonacci.MdiParent = this;
            fibonacci.Show();
            
        }

        private void mÊSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMes mes = new frmMes();
            mes.MdiParent = this;
            mes.Show();
            
        }

        private void fUTEBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFutebol futebol = new frmFutebol();
           futebol.MdiParent = this;
            futebol.Show();
            
        }

        private void mENOREMAIORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaiorMenor maiorMenor = new frmMaiorMenor();
           maiorMenor.MdiParent = this;
            maiorMenor.Show();
            
        }

        private void fATORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFatorial fatorial = new frmFatorial();
            fatorial.MdiParent = this;
            fatorial.Show();
           
        }

        private void uTILITÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timeEfeitoDigitacao_Tick(object sender, EventArgs e)
        {
           
        }

        private void cADASTRARPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProd cadastrarProd = new frmCadastrarProd();
            cadastrarProd.MdiParent = this;
            cadastrarProd.Show();
        }

        private void CONSULTARCADASTRO_Click(object sender, EventArgs e)
        {
            frmConsultarProd consultarProd = new frmConsultarProd();
            consultarProd.MdiParent = this;
            consultarProd.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
