namespace Projeto_CSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // true, o numero 1 só será incrementado após a comparação e o numero2 será decrementando antes da comparação.
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
