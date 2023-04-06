using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    class DesafioAtributo
    {   
        int a = 10;

        public static void Executar() {
            // Acessar a variável "a" dentro do método executar
            var atributo = new DesafioAtributo();
            Console.WriteLine(atributo.a);
        }
    }
}