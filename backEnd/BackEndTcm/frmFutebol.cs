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
    public partial class frmFutebol : Form
    {
        public frmFutebol()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
         this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClassificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter idade do TextBox
                int idade = int.Parse(txtIdade.Text);

                string categoria;

                // Determinar a categoria com base na idade
                if (idade >= 5 && idade <= 10)
                {
                    categoria = "Infantil";
                }
                else if (idade >= 11 && idade <= 15)
                {
                    categoria = "Juvenil";
                }
                else if (idade >= 16 && idade <= 20)
                {
                    categoria = "Júnior";
                }
                else if (idade >= 21 && idade <= 25)
                {
                    categoria = "Profissional";
                }
                else
                {
                    categoria = "Idade fora das categorias definidas.";
                }

                // Exibir o resultado no TextBox
                txtResultado.Text = $"Categoria: {categoria}";
                txtResultado.ForeColor = System.Drawing.Color.Black; // Cor padrão
            }
            catch (FormatException)
            {
                // Tratamento para entrada inválida
                txtResultado.Text = "Por favor, digite uma idade válida!";
                txtResultado.ForeColor = System.Drawing.Color.Red; // Exibe o erro em vermelho
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtResultado.Clear();
        }
    }
}
