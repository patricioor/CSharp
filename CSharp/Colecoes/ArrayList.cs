using System;
using System.Collections;


namespace Projeto_CSharp.Colecoes
{
    public class ArrayList // Sobreposição proposital
    {
        public static void Executar() {
            var arraylist = new System.Collections.ArrayList {"Pessoa", 3, true};

            arraylist.Add(3.14);
            
            foreach(object item in arraylist) {
                System.Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}