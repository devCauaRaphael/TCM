﻿using System;
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

    public partial class frmConsultarProd : Form
    {
        string caminhoProd = @"C:\Users\cauaz\OneDrive\Área de Trabalho\TCM\backEnd\BackEndTcm\database\produto.txt";
        public frmConsultarProd()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<string> listas = new List<string>();
            string lista;

            using (StreamReader sr = new StreamReader(caminhoProd))
            {
                while ((lista = sr.ReadLine()) != null)
                {
                    listas.Add(lista);
                }
                lsbConsulta.DataSource = listas;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoProd))
            {
                try
                {

                    var linhas = File.ReadAllLines(caminhoProd).ToList();

                    File.WriteAllText(caminhoProd, string.Empty);

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}