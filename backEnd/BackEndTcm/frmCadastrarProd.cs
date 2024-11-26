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
    public partial class frmCadastrarProd : Form
    {
        string caminhoProd = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\produto.txt";
        public frmCadastrarProd()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtNome.Text == "" )
            {
                MessageBox.Show("Dados Invalidos");
            }
            else
            {
                StreamWriter sw = new StreamWriter(caminhoProd, true);
                sw.WriteLine(txtUsuario.Text);
                sw.WriteLine(txtNome.Text);

                sw.WriteLine("----------------------------------------");
                MessageBox.Show("Cadastro realizado com sucesso!");

                sw.Close();
                txtUsuario.Clear();
                txtNome.Clear();
               

            
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtNome.Clear();
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
