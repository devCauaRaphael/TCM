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
    public partial class frmUtilitarios : Form
    {
        public frmUtilitarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            frmFibonacci fibonacci = new frmFibonacci();
            fibonacci.Show();
            this.Hide(); 
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            frmMes mes = new frmMes();
            mes.Show();
            this.Hide();
        }

        private void btnFutebol_Click(object sender, EventArgs e)
        {
            frmFutebol futebol = new frmFutebol();
            futebol.Show();
            this.Hide();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            frmFatorial fatorial = new frmFatorial();
            fatorial.Show();
            this.Hide();
        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            frmMaiorMenor maiorMenor = new frmMaiorMenor();
            maiorMenor.Show();
            this.Hide();
        }
    }
}
