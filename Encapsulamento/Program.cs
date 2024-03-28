using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Tigela", 1.99);
            Produto p2 = new Produto("Macbook Wind", 999.90, 100);            
            Console.WriteLine(p1.Nome);
            p1.Nome = "Tupperware";
        }
    }
}
