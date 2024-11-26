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
    public partial class frmLogin : Form
    {   
        string caminhoLogin =  @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\login.txt";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (txtUsuario.Text == "Admin" && txtSenha.Text == "cidade123" || txtUsuario.Text == "caminhoLogin" && txtSenha.Text == "caminhoLogin")
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    MessageBox.Show("acesso ao sistema realizado!");
                    this.Hide();
                }
            
                else {
                    MessageBox.Show("Usuário ou senha inválidos!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtSenha.Focus();
                    txtUsuario.Clear();
                    txtSenha.Clear();
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
    }
    }

