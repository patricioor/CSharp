namespace Projeto_CSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Digite um número: ");
                int.TryParse(Console.ReadLine(), out palpite);
                tentativasRestantes--;
                tentativas++;
                if (palpite > numeroSecreto) {
                    Console.WriteLine("Número errado! Tente um número menor!");
                    Console.WriteLine("Número de tentativas restantes: {0}", tentativasRestantes);
                } else 
                    if( palpite < numeroSecreto ) {
                        Console.WriteLine("Número errado! Tente um número maior!");
                        Console.WriteLine("Número de tentativas restantes: {0}", tentativasRestantes);
                    } else {
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Você acertou! Número encontrado em {0} tentativas'", tentativas);
                        numeroEncontrado = true;
                        Console.BackgroundColor = corAnterior;
                        break;
                }
                if (tentativasRestantes == 0 && !numeroEncontrado) {
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número errado! Tente um número maior!");
                    Console.BackgroundColor = corAnterior;
                    Console.WriteLine("Limite de tentativas atingido, o número secreto era '{0}'", numeroSecreto);
                }
            }
        }
    }
}
