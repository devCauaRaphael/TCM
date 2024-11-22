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
    public partial class frmConsultarCliente : Form
    {
        string caminho = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\arquivo.txt";
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminho))
            {
                try
                {
                    
                    using (StreamReader sw = new StreamReader(caminho))
                    {
                        
                        string conteudo = sw.ReadToEnd();

                        
                        txtNome.Text = conteudo;
                        txtEmail.Text = conteudo;
                        txtUsuario.Text = conteudo;
                        txtSenha.Text = conteudo;
                        mskTelefone.Text = conteudo;
                    }
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
                }
            }
            else
            {
                
                MessageBox.Show("Arquivo não encontrado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
