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
            if (File.Exists(caminho))
            {
                // criação de uma lista, que armazenará todas as linhas do arquivo
                List<string> listas = new List<string>();
                string lista;

                using (StreamReader sr = new StreamReader(caminho))
                {
                    // lê todas as linhas do arquivo e adiciona na lista
                    while ((lista = sr.ReadLine()) != null)
                    {
                        listas.Add(lista);
                    }
                }

                if (listas.Count > 0) // Verifica se há registros na lista
                {
                    lsbConsulta.DataSource = listas; // Atualiza a fonte de dados da lista
                }
                else
                {
                    MessageBox.Show("Não há registros no arquivo para consulta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (File.Exists(caminho))
            {
                try
                {
                    var linhas = File.ReadAllLines(caminho).ToList();

                    if (linhas.Count > 0) // Verifica se há registros no arquivo
                    {
                        File.WriteAllText(caminho, string.Empty); // Limpa o conteúdo do arquivo

                        MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não há registros no arquivo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            



        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
