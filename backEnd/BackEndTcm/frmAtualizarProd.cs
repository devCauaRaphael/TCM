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

namespace BackEndTcm
{
    public partial class frmAtualizarProd : Form
    {
        string caminhoProd = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\produto.txt";
        public frmAtualizarProd()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string registroAntigo = caminhoProd; 
            string usuario = txtUsuario.Text;
            string novoNome = txtNome.Text; // Novo nome fornecido
        

            if (File.Exists(caminhoProd))
            {
                try
                {
                    // Lê todas as linhas do arquivo
                    var linhas = File.ReadAllLines(caminhoProd);

                    bool registroAtualizado = false;


                    for (int i = 0; i < linhas.Length; i++)
                    {

                        string linha = linhas[i];

                        // Verifica se o nome de usuário está presente na linha
                        if (linha.Contains(usuario))
                        {

                            linhas[i] = $"{usuario} - {novoNome}";

                            // Marca que o registro foi atualizado
                            registroAtualizado = true;
                            break;
                        }
                    }

                    // Se o registro foi encontrado e atualizado
                    if (registroAtualizado)
                    {

                        File.WriteAllLines(caminhoProd, linhas);
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        // Caso não tenha encontrado o usuário
                        MessageBox.Show("Usuário não encontrado para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Caso ocorra um erro ao tentar ler ou escrever no arquivo
                    MessageBox.Show($"Erro ao acessar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo de cadastro não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
           txtUsuario.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
