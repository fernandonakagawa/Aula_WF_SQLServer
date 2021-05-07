﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = BD.InserirCliente(new Cliente(tbNome.Text, tbTelefone.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
            finally
            {
                if (i > 0)
                {
                    MessageBox.Show($"Cadastro de {tbNome.Text} efetuado com sucesso!");
                    tbNome.Text = "";
                    tbTelefone.Text = "";
                }
                else MessageBox.Show("Erro ao cadastrar!");
            }
            Atualizar();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            lbTabela.Text = "Clientes:";
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = BD.SelectClientes();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dgvClientes.DataSource = tabela;
                    dgvClientes.ClearSelection();
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }

        private void btBuscarTelefone_Click(object sender, EventArgs e)
        {
            lbTabela.Text = "Busca por TELEFONE:";
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = BD.BuscarClientePorTelefone(tbTelefone.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dgvClientes.DataSource = tabela;
                    dgvClientes.ClearSelection();
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }
    }
}
