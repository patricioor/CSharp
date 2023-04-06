using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class MetodosEstaticos
    {
        public class CalculadoraEstatica {
            // Método de Classe ou Método estático
            public static int Somar(int a, int b) {
                return a + b;
            }
            // Método de instância
            public static int Multiplicar(int a, int b) {
                return a + b;
            }
        }
        public static void Executar(){
            var resultado = CalculadoraEstatica.Multiplicar(2,2);
            System.Console.WriteLine("Resultado: {0}", resultado);

            System.Console.WriteLine(CalculadoraEstatica.Somar(2,2));
        }
    }
}