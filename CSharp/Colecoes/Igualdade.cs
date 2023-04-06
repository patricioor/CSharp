using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.Colecoes
{
    public class Igualdade
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.92);
            var p2 = new Produto("Caneta", 1.92);
            System.Console.WriteLine(p1 == p2); // false, as variáveis apontam para lugares diferentes na memória

            var p3 = p2;
            System.Console.WriteLine(p2 == p3); // verdadeiro, as variáveis apontam para o mesmo lugar.

            System.Console.WriteLine(p1.Equals(p2)); // false, Equials compara endereços de memória

        }
    }
}