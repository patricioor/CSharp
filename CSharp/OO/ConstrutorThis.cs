using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.OO
{
    public class Animal {
        public string Nome {get; set;}
        public Animal (string nome) {
            Nome = nome;
        }
    }
    
    public class Cachorro: Animal {
        public double Altura {get; set;}
        public Cachorro(string nome): base (nome) {
            System.Console.WriteLine($"Cachoror {nome} inicializado");
        }

        public Cachorro (string nome, double altura) : this (nome) {
            Altura = altura;
        }

        //Personalizar o retorno em alguns contextos um objeto no ToString()
        public override string ToString()
        {
            return $"{Nome} tem {Altura} de altura.";
        }
    }
    public class ConstrutorThis
    {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max",0.40);
            System.Console.WriteLine(spike);
            System.Console.WriteLine(spike.ToString());
            System.Console.WriteLine(max);
            System.Console.WriteLine(max.ToString());
        }
    }
}