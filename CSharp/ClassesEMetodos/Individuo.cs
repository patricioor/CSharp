using System;

namespace Projeto_CSharp.ClassesEMetodos {
    class Individuo {
        public string Nome;
        public int Idade;   

        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e tenho idade {Idade} anos.");
        }     

        public void ApresentarNoConsole () {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}