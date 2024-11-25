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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fibonacciSequence = GenerateFibonacci(20);
            txtResultado.Text = fibonacciSequence;
        }
        private string GenerateFibonacci(int n)
        {
            int primeiro = 0, segundo = 1, prox;
            string result = $"{primeiro}, {segundo}"; 

            for (int i = 3; i <= n; i++)
            {
                prox = primeiro + segundo;
                result += $", {prox}";

               
                primeiro = segundo;
                segundo = prox;
            }

            return result;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
