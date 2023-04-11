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

        static void ImprimirMinhaSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(4,6));

            ImprimirSoma op2 = ImprimirMinhaSoma;
            op2(7, 8.2);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5,3));

            Action<double, double> op4 = ImprimirMinhaSoma;
            op4(7.7, 23.4);
        }
    }
}
