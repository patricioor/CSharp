namespace Projeto_CSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3;  // num1 = num1 - 3;
            num1 *= 8;  // num1 = num1 * 8;
            num1 /= 10; // num1 = num1 / 10

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}");
        }
    }
}
