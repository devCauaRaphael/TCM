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
    public partial class frmMes : Form
    {
        public frmMes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarMes_Click(object sender, EventArgs e)
        {
            int numeroMes;

            // Tenta converter o valor digitado para inteiro
            bool isNumeroValido = int.TryParse(txtNumeroMes.Text, out numeroMes);

            // Verifica se o número é válido e está entre 1 e 12
            if (isNumeroValido && numeroMes >= 1 && numeroMes <= 12)
            {
                string[] meses = new string[]
                {
                    "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                    "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
                };

                // Exibe o mês correspondente ao número no TextBox
                txtResultado.Text = meses[numeroMes - 1];
            }
            else
            {
                // Caso o número não seja válido, exibe uma mensagem de erro no TextBox
                txtResultado.Text = "Por favor, digite um número entre 1 e 12.";
            }
        }
    }
}
