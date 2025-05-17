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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BackEndTcm
{
    public partial class frmNovoLogin : Form

    {
        string registro = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\registro.txt";
        string loginUsuario = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\usuario.txt";
        string loginSenha = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\senha.txt";
        public frmNovoLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           string senha = txtSenha.Text;
            string usuario = txtUsuario.Text;

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("EXISTE UM CAMPO VAZIO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                 // verifica se há registro duplicado
                bool duplicado = false;
                if (File.Exists(loginUsuario))
                {
                    // leitura de todas as linhas do arquivo
                    string[] usuariosCadastrados = File.ReadAllLines(loginUsuario);
                    duplicado = usuariosCadastrados.Contains(usuario);
                }


                if (duplicado)
                {
                    MessageBox.Show("Usuário já cadastrado.", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    using (StreamWriter sw = new StreamWriter(registro, true))
                    {
                        sw.WriteLine(txtUsuario.Text);
                        sw.Write(txtSenha.Text);

                    }
                    using (StreamWriter sw = new StreamWriter(loginSenha, true))
                    {
                        sw.WriteLine(senha);
                    }
                    using (StreamWriter sw = new StreamWriter(loginUsuario, true))
                    {
                        sw.WriteLine(usuario);
                    }
                    MessageBox.Show($"Registro concluido com sucesso!", "Registro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        
            this.Hide();
        }

        private void frmNovoLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
