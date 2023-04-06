using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDateNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    public class Readonly
    {
        public static void Executar() {
            var cliente1 = new Cliente ("Xico",new DateTime(1995,2,13));

            System.Console.WriteLine(cliente1.Nome);
            System.Console.WriteLine(cliente1.GetDateNascimento());
        }
    }
}