using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Produto {
        public string Nome = "a";
        public double Preco;
        public static double Desconto = 0.1;

        public Produto (string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {}

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }
    public class AtributosEstaticos
    {
        public static void Executar() {
            var produto1 = new Produto("Copo", 5, 0.12);
            
            var produto2 = new Produto() {
                Nome = "Prato",
                Preco = 3
            };

            System.Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
            System.Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.1;

            System.Console.WriteLine("Preço com desconto {0}", produto1.CalcularDesconto());
            System.Console.WriteLine("Preço com desconto {0}", produto2.CalcularDesconto());
            
        }
    }
}