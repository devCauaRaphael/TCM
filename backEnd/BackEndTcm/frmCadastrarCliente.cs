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
            if(txtUsuario.Text == "" || txtNome.Text == "" || txtSenha.Text == "" || txtEmail.Text == "" || mskTelefone.Text == "")
            {
                MessageBox.Show("Dados Invalidos");
            }
            else
            {
                StreamWriter sw = new StreamWriter(caminho, true);
                sw.WriteLine(txtUsuario.Text);
                sw.WriteLine(txtNome.Text);
                sw.WriteLine(txtEmail.Text);
                sw.WriteLine(txtSenha.Text);
                sw.WriteLine(mskTelefone.Text);
                sw.WriteLine("----------------------------------------");
                MessageBox.Show("Cadastro realizado com sucesso!");

                sw.Close();
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                mskTelefone.Clear();
                
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
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
