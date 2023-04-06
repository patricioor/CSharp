using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_CSharp.Colecoes
{
    public class Set
    {
        public static void Executar() {
            var livro = new Produto ("A volta dos que não foram", 200.50);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 20),
                new Produto("Bermuda", 30),
                new Produto("Meia", 10),
            };

            carrinho.UnionWith(combo);
            System.Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); // Removeu "Meia"

            foreach(var item in carrinho) {
            //    System.Console.Write(carrinho.IndexOf(item));
               System.Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            System.Console.WriteLine(carrinho.Count());
            carrinho.Add(livro);
            System.Console.WriteLine(carrinho.Count());
        }
    }
}