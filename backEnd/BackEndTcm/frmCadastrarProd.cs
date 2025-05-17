using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackEndTcm
{
    public partial class frmCadastrarProd : Form
    {
        string caminhoProd = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\produto.txt";
        public frmCadastrarProd()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "" || cbProduto.Text == "")
            {
                MessageBox.Show("Dados invalidos!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                StreamWriter sw = new StreamWriter(caminhoProd, true);

                if (cbCategoria.SelectedItem == "Jogo")
                {
                    sw.WriteLine("Produto: Jogo ");
                }
                else
                {
                    sw.WriteLine("Produto: Controle");
                }
                
                if (cbCategoria.SelectedItem == "Jogo")
                {
                    if (cbProduto.SelectedItem == "Horizon Zero Down")
                    {
                        sw.WriteLine("Jogo: Horizon Zero Down");
                        sw.WriteLine("Valor: R$199,99");

                    }
                    else if (cbProduto.SelectedItem == "Nba2k25")
                    {
                        sw.WriteLine("Jogo: Nba2k25");
                        sw.WriteLine("Valor: R$299,99");

                    }
                    else if(cbProduto.SelectedItem == "Mortal Kombat 1 ")
                    {
                        sw.WriteLine("Jogo: Mortal Kombat 1");
                        sw.WriteLine("Valor: R$199,99");
                            
                    }
                    else if( cbProduto.SelectedItem =="Resident evil 4")
                    {
                        sw.WriteLine("Jogo: Resident Evil");
                        sw.WriteLine("Valor: R$200,00");
                    }
                    else if(cbProduto.SelectedItem == "Jojo Bizarre Adventure")
                    {
                        sw.WriteLine("Jogo: Jojo Bizarre Adventure");
                        sw.WriteLine("Valor: R$99,99");

                    }
                    else if(cbProduto.SelectedItem == "GTA 5")
                    {
                        sw.WriteLine("Jogo: GTA 5");
                        sw.WriteLine("Valor: R$99,99");
                    }
                    else if(cbProduto.SelectedItem == "Madden NFL 2k25")
                    {
                        sw.WriteLine("Jogo: Madden NFL 2k25");
                        sw.WriteLine("Valor: R$399,99");
                    }
                    else if(cbProduto.SelectedItem == "Star Wars Outlaws")
                    {
                        sw.WriteLine("Jogo: Star Wars Outlaws");
                        sw.WriteLine("Valor: R$295,90");
                    }
                    else if(cbProduto.SelectedItem =="EAFC 25" )
                    {
                        sw.WriteLine("Jogo: EAFC 25");
                        sw.WriteLine("Valor: R$299,99");
                    }
                    else if(cbProduto.SelectedItem == "Squad Suicide")
                    {
                        sw.WriteLine("Jogo: Squad Suicide");
                        sw.WriteLine("Valor: R$279,99");
                    }
                    else if(cbProduto.SelectedItem == "Spiderman Miles Morales")
                    {
                        sw.WriteLine("Jogo: Squad Suicide");
                        sw.WriteLine("Valor: R$279,99");
                    }
                }
                else
                {
                     if (cbProduto.SelectedItem == "controle tradicional PS5")
                    {
                        sw.WriteLine("Controle: tradicional PS5");
                        sw.WriteLine("Valor: R$400,00");

                    }
                    else if (cbProduto.SelectedItem == "Controle azul PS5")
                    {
                        sw.WriteLine("Controle: azul PS5");
                        sw.WriteLine("Valor: R$450,00");
                    }
                    else if(cbProduto.SelectedItem == "Controle vermelho PS5")
                    {
                        sw.WriteLine("Controle: azul PS5");
                        sw.WriteLine("Valor: R$450,00");
                    }
                     else if(cbProduto.SelectedItem == "Controle roxo XBOX")
                    {
                        sw.WriteLine("Controle: roxo XBOX");
                        sw.WriteLine("Valor: R$350,00");
                    }
                    else if (cbProduto.SelectedItem == "Controle verde XBOX")
                    {
                        sw.WriteLine("Controle: verde XBOX");
                        sw.WriteLine("Valor: R$350,00");
                    }
                }

                sw.WriteLine("----------------------------------------");
                MessageBox.Show("Cadastro bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
               sw.Close();
                            
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
          
            
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarProd_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           
           
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
