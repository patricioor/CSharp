namespace Projeto_CSharp.Fundamentos {
    class NumeroPrimo {
        public static void Executar() {

            int contadorDeDivisores = 0;
            Console.WriteLine("insira um número para saber se este é primo?");
            int.TryParse(Console.ReadLine(), out var numeroTentativa);
            if (numeroTentativa < 0) {
                Console.WriteLine("número inválido");
            }
            else {
                for (var i = numeroTentativa; i > 0; i--) {
                    if (numeroTentativa % i == 0) contadorDeDivisores++;
                }
            }
            var resultado = contadorDeDivisores > 2 ? "O número não é primo, pois possui mais de dois divisores" : "O número é primo";
            Console.WriteLine("O número inserido é primo? {0}", resultado);
        }
    }
}
