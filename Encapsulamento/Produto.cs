using System;

namespace Encapsulamento
{
    public class Produto
    {
        const string NOME_EMPRESA = "Teste SA";
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            {
                Console.WriteLine("Nome nulo ou com menos de 3 caracteres");
                return;
            }

            _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double valor)
        {
            if(valor < 0)
            {
                Console.WriteLine("Valor do preco não pode ser negativo");
                return;
            }

            _preco = valor;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            if(quantidade < 0)
            {
                Console.WriteLine("Quantidade não pode ser negativa");
                return;
            }

            _quantidade = quantidade;

        }
    }
}