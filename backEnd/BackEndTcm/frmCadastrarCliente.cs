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
    public partial class frmCadastrarCliente : Form
    {
        string caminho = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\arquivo.txt";
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
            
        {
            string usuario = txtUsuario.Text;
            string nome = txtNome.Text;
            string senha = txtSenha.Text;   
            string email = txtEmail.Text;   
            string telefone = mskTelefone.Text;

            if(txtUsuario.Text == "" || txtNome.Text == "" || txtSenha.Text == "" || txtEmail.Text == "" || mskTelefone.Text == "")
            {
                MessageBox.Show("Usuario ou senha incorretos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool duplicado = false;
                if (File.Exists(caminho))
                {
                    using (StreamReader sr = new StreamReader(caminho))
                    {
                        string linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            if (linha.Contains("usuario: " + usuario) || linha.Contains("email: " + email))
                            {
                                duplicado = true;
                                break;
                            }
                        }
                    }
                }

                if (duplicado)
                {
                    MessageBox.Show("Usuário ou e-mail já cadastrados.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(caminho, true);
                    sw.WriteLine("usuario: " + txtUsuario.Text);
                    sw.WriteLine("nome: " + txtNome.Text);
                    sw.WriteLine("email: " + txtEmail.Text);
                    sw.WriteLine("senha: " + txtSenha.Text);
                    sw.WriteLine("telefone: " + mskTelefone.Text);
                    sw.WriteLine("----------------------------------------");
                    MessageBox.Show("Cadastro bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sw.Close();
                    txtUsuario.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtSenha.Clear();
                    mskTelefone.Clear();


                   
                }


                
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            mskTelefone.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
