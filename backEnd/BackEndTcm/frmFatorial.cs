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
    public partial class frmFatorial : Form
    {
        public frmFatorial()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int fat = 1;
            int n = int.Parse(txtDigito.Text);

            if (n < 0)
            {
                String resultado = ("o fatorial não se define por números negativos.");
                txtResultado.Text = resultado.ToString();
            }
            if ((n == 0) || (n == 1))
            {
                String resultado = ("o fatorial é 1.");
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                for (int cont = n; cont >= 1; cont--)
                {
                    fat *= cont;

                }
                string resultado = $"O fatorial de {n} é {fat}.";
                txtResultado.Text = resultado;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDigito.Clear();
            txtResultado.Clear();
        }
    }
}
