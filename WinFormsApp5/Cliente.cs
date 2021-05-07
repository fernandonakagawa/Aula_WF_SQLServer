using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp5
{
    class Cliente
    {
        private string _nome;
        private string _telefone;

        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
