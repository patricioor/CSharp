using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Dependente {
        public string Nome;
        public int Idade;
    }
    public class ValorVsReferencia
    {
        public static void Executar() {
            var dependente = new Dependente() {
                Nome = "Patrício",
                Idade = 22
            };

            Dependente dep = dependente;

            System.Console.WriteLine($"{dep.Nome} {dependente.Nome}");
            dependente.Idade++;
            System.Console.WriteLine($"{dep.Idade} {dependente.Idade}");
           

            dependente.Nome = "Manel";
            dep.Idade = 25;

            System.Console.WriteLine($"{dep.Nome} {dependente.Nome}");
            System.Console.WriteLine($"{dep.Idade} {dependente.Idade}");
        }
    }
}