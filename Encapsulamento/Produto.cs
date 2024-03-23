using System;

namespace Encapsulamento
{
    public class Produto
    {
        const string NOME_EMPRESA = "Teste SA";
        private string _nome;
        private double _preco;
        public int Quantidade { get; set;}

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Nome nulo ou com menos de 3 caracteres");
                    return;
                }
                _nome = value;
            }
        }

        public double Preco
        {
            get {return _preco;}
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Preço não pode ser negativo");
                    return;
                }
                
                _preco = value;
            }
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}