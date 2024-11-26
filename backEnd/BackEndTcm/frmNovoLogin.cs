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
    public partial class frmNovoLogin : Form
    {
        string caminhoLogin = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\login.txt";
        public frmNovoLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Dados Invalidos");
            }
            else
            {
                StreamWriter sw = new StreamWriter(caminhoLogin, true);
                sw.WriteLine(txtUsuario.Text);       
                sw.WriteLine(txtSenha.Text);
                sw.WriteLine("----------------------------------------");
                MessageBox.Show("Cadastro realizado com sucesso!");

                sw.Close();
               txtUsuario.Clear();
                txtSenha.Clear();

                this.Hide();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmNovoLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
