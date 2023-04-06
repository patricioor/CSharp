namespace Projeto_CSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie o atendimento, a avaliação varia de 0 a 5, onde 5 é totalmente satisfeito e 0 totalmente satisfeito");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Totalmente insatisfeito");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Insatisfeito");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Satisfeito");
                    break;
                case 5:
                    Console.WriteLine("Total satisfeito");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("Fim!");
        }
    }
}
