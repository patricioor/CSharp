using System;

namespace Projeto_CSharp.Colecoes
{
    public class Queue
    {
        public static void Executar() {
            var fila = new Queue<string> ();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            System.Console.WriteLine(fila.Peek());// pega os elementos por ordem
            System.Console.WriteLine(fila.Count); // e não os remove

            System.Console.WriteLine(fila.Dequeue()); // tira o próximo da fila
            System.Console.WriteLine(fila.Count());

            var salada = new System.Collections.Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(3);
            salada.Enqueue(false);
            salada.Enqueue(3.14);
            
            System.Console.WriteLine(salada.Contains("Item")); //true
            System.Console.WriteLine(salada.Contains("item")); //false
        }
    }
}