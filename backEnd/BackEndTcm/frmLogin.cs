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
    public partial class frmLogin : Form

    {
        private bool senhaVisivel = false;
        string loginUsuario = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\usuario.txt";
        string loginSenha = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\senha.txt";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Usuário ou senha incorretos!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtSenha.Focus();
                txtUsuario.Clear();
                txtSenha.Clear();
            }


            else if (File.Exists(loginUsuario) && File.Exists(loginSenha))
            {
                string[] usuarios = File.ReadAllLines(loginUsuario);
                string[] senhas = File.ReadAllLines(loginSenha);
                bool loginEncontrado = false;
                for (int i = 0; i < usuarios.Length; i++)
                {
                    if (i < senhas.Length && usuarios[i] == usuario && senhas[i] == senha)
                    {
                        MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginEncontrado = true;
                        this.Hide();
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        break;
                    }
                }
                if (!loginEncontrado)
                {
                    MessageBox.Show("Usuario ou senha incorretos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            frmNovoLogin novoLogin = new frmNovoLogin();
            novoLogin.Show();
           
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
    }

