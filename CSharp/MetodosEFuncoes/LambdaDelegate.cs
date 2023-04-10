namespace CSharp.MetodosEFuncoes
{
    internal class LambdaDelegate
    {
        delegate double Operacao(double x, double y);
        public static void Executar ()
        {
            Operacao sum = (x,y) => x + y;
            Operacao sub = (x,y) => x - y;
            Operacao mult = (x,y) => x * y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(10,7));
            Console.WriteLine(mult(5,6));
        }
    }
}
