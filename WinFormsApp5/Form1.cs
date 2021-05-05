using System;
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
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Aula;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = "INSERT INTO Clientes (Nome, Telefone) VALUES (@nome,@telefone)";
            sql.Parameters.AddWithValue("@nome", tbNome.Text);
            sql.Parameters.AddWithValue("@telefone", tbTelefone.Text);

            conexao.Open();
            int i = sql.ExecuteNonQuery();
            conexao.Close();
            if (i > 0)
            {
                MessageBox.Show($"Cadastro de {tbNome.Text} efetuado com sucesso!");
                tbNome.Text = "";
                tbTelefone.Text = "";
            }
            else MessageBox.Show("Erro ao cadastrar!");

        }
    }
}
