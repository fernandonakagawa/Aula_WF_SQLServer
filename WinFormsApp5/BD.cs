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
        public static int Executar()
        {
            return Executar(out SqlDataAdapter adaptador);
        }
        public static int InserirCliente(Cliente c)
        {
            sql = new SqlCommand();
            sql.CommandText = "INSERT INTO Clientes (Nome, Telefone) VALUES (@nome,@telefone)";
            sql.Parameters.AddWithValue("@nome", c.Nome);
            sql.Parameters.AddWithValue("@telefone", c.Telefone);
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }

        public static SqlDataAdapter SelectClientes()
        {
            sql = new SqlCommand();
            sql.CommandText = "SELECT * FROM Clientes";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }

        public static SqlDataAdapter BuscarClientePorTelefone(string telefone)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT * FROM Clientes " +
                $"WHERE Telefone LIKE '%{telefone}%'";
            int linhasAfetadas = Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }

        public static int ExcluirCliente(int id)
        {
            sql = new SqlCommand();
            sql.CommandText = $"DELETE FROM Clientes " +
                $"WHERE idCliente = {id}";
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }

        public static int EditarCliente(int id, Cliente c)
        {
            sql = new SqlCommand();
            /*sql.CommandText = "UPDATE Clientes SET Nome = @nome, Telefone = @telefone  " +
                "WHERE idCliente = @id";
            sql.Parameters.AddWithValue("@nome", c.Nome);
            sql.Parameters.AddWithValue("@telefone", c.Telefone);
            sql.Parameters.AddWithValue("@id", id);
        
            */
            sql.CommandText = $"UPDATE Clientes Set Nome = '{c.Nome}', Telefone = '{c.Telefone}' " +
                $"WHERE idCliente = {id}";
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }
    }
}
