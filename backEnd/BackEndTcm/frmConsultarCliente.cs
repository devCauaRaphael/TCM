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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void lsbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            List<string> listas = new List<string>();
            string lista;

            using (StreamReader sr = new StreamReader(caminho))
            {
                while ((lista = sr.ReadLine()) != null)
                {
                    listas.Add(lista);
                }
                lsbConsulta.DataSource = listas;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
