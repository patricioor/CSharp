namespace CSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static double Subtracao(this double num, double outroNumero)
        {
            return num - outroNumero;
        }
    }
    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int num = 5;
            double num1 = 6;

            Console.WriteLine(num.Soma(2));
            Console.WriteLine(num1.Subtracao(1));

            Console.WriteLine(10.Soma(19));
            Console.WriteLine(20.5.Subtracao(16.24));
        }
    }
}
