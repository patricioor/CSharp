using System;


namespace Projeto_CSharp.ClassesEMetodos
{   
    class CalculadoraComum {
        public double Somar(double a, double b) {
            return a + b;
        }

        public double Subtrair(double a, double b) {
            return a - b;
        }

        public double Multiplicar(double a, double b) {
            return a * b;
        }

        public double Dividir(double a, double b) {
            return a/b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir () {
            System.Console.WriteLine(memoria);
            return this;
        }

        public CalculadoraCadeia Zerar() {
            memoria = 0;
            return this;
        }

        public int Resultado() {
            return memoria;
        }

       
    }
    class MetodosComRetorno
    {
        public static void Executar() {
            var opcao = 0;  

             do{
                
                int a, b;
                var calculadoraComum = new CalculadoraComum();
                Console.WriteLine("---Calculadora Simples---");
                Console.WriteLine("1) Somar");
                Console.WriteLine("2) Subtrair");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir:");
                System.Console.WriteLine(("5) Exemplo calculadora em cadeia"));
                System.Console.WriteLine("0) Sair");
                int.TryParse(Console.ReadLine(), out opcao);
                switch(opcao) {
                    case 1:
                        Console.WriteLine("Inserir os número que deseja saber a soma");
                        int.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("+");
                        int.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("_____");
                        Console.WriteLine(calculadoraComum.Somar(a,b));
                        break;
                    case 2:
                        Console.WriteLine("Inserir os número que deseja saber a subtrair");
                        int.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("-");
                        int.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("_____");
                        Console.WriteLine(calculadoraComum.Subtrair(a,b));
                        break;
                    case 3:
                        Console.WriteLine("Inserir os número que deseja saber a multiplicar");
                        int.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("*");
                        int.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("_____");
                        Console.WriteLine(calculadoraComum.Multiplicar(a,b));
                        break;
                    case 4:
                        Console.WriteLine("Inserir os número que deseja saber a dividir");
                        int.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine("/");
                        int.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("_____");
                        Console.WriteLine(calculadoraComum.Dividir(a,b));
                        break;
                    case 5:
                         var calculadoraCadeia = new CalculadoraCadeia();
                         System.Console.WriteLine("calculadoraCadeia.Somar(4).Multiplicar(2).Imprimir().Zerar().Imprimir();");
                         calculadoraCadeia.Somar(4).Multiplicar(2).Imprimir().Zerar().Imprimir();
                         break;
                    default:
                        opcao = 0;
                        System.Console.WriteLine("---FIM---");
                        break;
                }
             } while(opcao != 0);
        }
    }
 }