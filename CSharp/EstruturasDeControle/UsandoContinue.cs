namespace Projeto_CSharp.EstruturasDeControle {
    class UsandoContinue {
        public static void Executar() {
            for(int i = 0; i <= 50 ; i++) {
                if (i % 2 ==1) {
                    continue;
                }
                Console.Write(i + " ");
            }
        Console.WriteLine("");
        }
    }
}
