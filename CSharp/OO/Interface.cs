namespace CSharp.OO
{
    interface IOperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Soma : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Substracao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Divisao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }

    class Calculadora
    {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria>
        {
            new Soma(),
            new Substracao(),
            new Multiplicacao(),
            new Divisao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }
    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 0);

            Console.WriteLine(resultado);
        }
    }
}
