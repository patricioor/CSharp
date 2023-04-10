
namespace CSharp.MetodosEFuncoes
{
    internal class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2,3.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(5,3.7));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(4, 16);
        }
    }
}
