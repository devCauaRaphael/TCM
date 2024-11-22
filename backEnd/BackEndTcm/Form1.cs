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
    public partial class Form1 : Form
    {
        string caminhoRegistro = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\registro.txt";
        string loginEmail = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\loginEmail.txt";
        string loginSenha = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\loginSenha.txt";


        public Form1()
        {
            InitializeComponent()

            txtSenha.PasswordChar = '*';
            txtLoginSenha.PasswordChar= '*';
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtLoginEmail.CharacterCasing = CharacterCasing.Lower;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
