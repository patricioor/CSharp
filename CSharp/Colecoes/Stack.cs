namespace Projeto_CSharp.Colecoes
{
    public class Stack
    {
        public static void Executar() {
            var pilha = new System.Collections.Stack();
                pilha.Push("Abc");
                pilha.Push(123);
                pilha.Push(false);
                pilha.Push(3.14f);

                System.Console.Write($"Pop: {pilha.Pop()} ");

                foreach(var item in pilha) Console.WriteLine($"{item}");

                System.Console.WriteLine($"\n Peek: {pilha.Peek()}");
                System.Console.WriteLine(pilha.Count);
        }
    }
}