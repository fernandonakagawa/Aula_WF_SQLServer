using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp5
{
    class BD
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand sql = new SqlCommand();

        private static SqlDataAdapter Inicializar()
        {
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Aula;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
            return adaptador;
        }
        public static int Executar(out SqlDataAdapter adaptador)
        {
            adaptador = Inicializar();
            int i = 0;
            conexao.Open();
            i = sql.ExecuteNonQuery();
            conexao.Close();
            return i;
        }
        public static int InserirCliente(Cliente c)
        {
            sql.CommandText = "INSERT INTO Clientes (Nome, Telefone) VALUES (@nome,@telefone)";
            sql.Parameters.AddWithValue("@nome", c.Nome);
            sql.Parameters.AddWithValue("@telefone", c.Telefone);
            int linhasAfetadas = Executar(out SqlDataAdapter adaptador);
            return linhasAfetadas;
        }

        public static SqlDataAdapter SelectClientes()
        {
            sql.CommandText = "SELECT Nome, Telefone FROM Clientes";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }

        public static SqlDataAdapter BuscarClientePorTelefone(string telefone)
        {
            sql.CommandText = $"SELECT Nome, Telefone FROM Clientes " +
                $"WHERE Telefone LIKE '%{telefone}%'";
            int linhasAfetadas = Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }

    }
}
