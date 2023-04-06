using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class ParametrosPorReferencia
    {
        public static void AlterarRef (ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut (out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar() {
            int a = 3; // Obrigado a ser inicializada para passar a variável como referência
            AlterarRef(ref a);
            System.Console.WriteLine(a);

            AlterarOut(out int b, out int c);
            System.Console.WriteLine("B: {0} e C: {1}",b,c);
        }
    }
}