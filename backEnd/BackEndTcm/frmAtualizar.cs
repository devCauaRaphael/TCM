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
    public partial class frmAtualizar : Form
    {
        string caminho = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\arquivo.txt";
        public frmAtualizar()
        {
            InitializeComponent();
        }

        private void frmAtualizar_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            string registroAntigo = caminho; // O registro que você quer atualizar
            string usuario = txtUsuario.Text; // O nome de usuário fornecido
            string novoNome = txtNome.Text; // Novo nome fornecido
            string novoEmail = txtEmail.Text; // Novo email fornecido
            string novaSenha = txtSenha.Text; // Nova senha fornecida
            string novoTelefone = mskTelefone.Text; // Novo telefone fornecido

            if (File.Exists(caminho))
            {
                try
                {
                    // Lê todas as linhas do arquivo
                    var linhas = File.ReadAllLines(caminho);

                    bool registroAtualizado = false;

                  
                    for (int i = 0; i < linhas.Length; i++)
                    {
                       
                        string linha = linhas[i];

                        // Verifica se o nome de usuário está presente na linha
                        if (linha.Contains(usuario))
                        {
                       
                            linhas[i] = $"{usuario} - {novoNome} - {novoEmail} - {novaSenha} - {novoTelefone}";

                            // Marca que o registro foi atualizado
                            registroAtualizado = true;
                            break; 
                        }
                    }

                    // Se o registro foi encontrado e atualizado
                    if (registroAtualizado)
                    {
                       
                        File.WriteAllLines(caminho, linhas);
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
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            mskTelefone.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
