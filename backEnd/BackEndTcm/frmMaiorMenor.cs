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
    public partial class frmMaiorMenor : Form
    {
        public frmMaiorMenor()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaiorMenor_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                // Lê os números digitados pelo usuário no TextBox
                string[] numerosString = txtNumeros.Text.Split(',');

                // Verifica se há exatamente 20 números
                if (numerosString.Length != 20)
                {
                    MessageBox.Show("Por favor, digite exatamente 20 números, separados por vírgula.");
                    return;
                }

                int[] numeros = new int[20];

                // Converte os números digitados para inteiros
                for (int i = 0; i < 20; i++)
                {
                    if (int.TryParse(numerosString[i].Trim(), out int numero))
                    {
                        numeros[i] = numero;
                    }
                    else
                    {
                        MessageBox.Show($"'{numerosString[i]}' não é um número válido.");
                        return;
                    }
                }

                // Calcula o maior e o menor valor
                int maiorValor = numeros[0];
                int menorValor = numeros[0];

                foreach (var numero in numeros)
                {
                    if (numero > maiorValor)
                    {
                        maiorValor = numero;
                    }
                    if (numero < menorValor)
                    {
                        menorValor = numero;
                    }
                }

                // Exibe os resultados nos TextBoxes
                txtMaior.Text = maiorValor.ToString();
                txtMenor.Text = menorValor.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMaior.Clear();
            txtMenor.Clear();
            txtNumeros.Clear();
        }
    }
}
