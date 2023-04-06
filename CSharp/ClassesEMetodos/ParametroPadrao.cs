using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_.ClassesEMetodos
{
    
    public class ParametroPadrao
    {
        public static int Somar(int a = 2, int b = 2) { // ref e out não aceitam receber valores padrões
         return a + b;
    }
        public static void Executar() {
            System.Console.WriteLine(Somar()); // 4
            System.Console.WriteLine(Somar(30)); // 32 -> 30(a) + 2(b)
            System.Console.WriteLine(Somar(a: 50)); // 52 -> 50(a) + 2(b)
            System.Console.WriteLine(Somar(b: 20)); // 22 -> 2(a) + 20(b)
        }
    }
}