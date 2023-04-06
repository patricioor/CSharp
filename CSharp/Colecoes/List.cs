using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_CSharp.Colecoes
{
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        //Equals e HashCode alinhados, ao colocar objetos dentro de coleções que usam hash as buscas e as definições funcionarão de forma correta
        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
    }
    public class List
    {
        public static void Executar() {
            var livro = new Produto ("A volta dos que não foram", 200.50);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 20),
                new Produto("Bermuda", 30),
                new Produto("Meia", 10),
            };

            carrinho.AddRange(combo);
            System.Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3); // Removeu "Meia"

            foreach(var item in carrinho) {
                System.Console.Write(carrinho.IndexOf(item));
                System.Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}