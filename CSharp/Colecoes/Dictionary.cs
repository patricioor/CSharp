using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.Colecoes
{
    public class Dictionary
    {
        public static void Executar() {
            var filmes = new System.Collections.Generic.Dictionary<int, string> ();
            filmes.Add(2000, "A volta dos que não foram");
            filmes.Add(2001,"A ida dos que não vão");
            filmes.Add(2002,"Come-chão e o Coçadinha");
            filmes.Add(2003,"007 - O retorno do Beltrano");

            if(filmes.ContainsKey(2000)) System.Console.WriteLine("2000: {0}", filmes[2000]);
            if(filmes.ContainsKey(2000)) System.Console.WriteLine("2000: {0}", filmes.GetValueOrDefault(2000)); // caso a chave não exista, retornará o default(string vazia)

            System.Console.WriteLine(filmes.ContainsValue("007 - Um novo dia para Fulano Morrer")); //false, valor não encontrado

            System.Console.WriteLine("Removeu? {0}", filmes.Remove(2001));
            
            filmes.TryGetValue(2003, out string filme2003);
            System.Console.WriteLine($"Filme: {filme2003}");

            // Formas de percorrer o Dictionary

            foreach(var chave in filmes.Keys) System.Console.WriteLine(chave);

            foreach(var valor in filmes.Values) System.Console.WriteLine(valor);

            foreach(KeyValuePair<int, string> filme in filmes) System.Console.WriteLine($"{filme.Value} é de {filme.Key}");

        }
    }
}