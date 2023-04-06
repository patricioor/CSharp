namespace Projeto_CSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook c5000";
            string marca = "Acer";
            double preco = 5800;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa: R$ " + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa: R$ {2}.", nome, marca, preco);
            Console.WriteLine($"O {nome} da marca {marca} custa: R$ {preco}.");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
