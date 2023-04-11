namespace CSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            //Action algoNoConsole = () => // é possível inserir parâmetros em action. mas seu retorno sempre será void
            //{
            //    Console.WriteLine("Lambda com C#!");
            //};
            Action<string> algoNoConsole = (a) =>
            {
                Console.WriteLine("Lambda com C#" + a);
            };

            algoNoConsole("!!!!!!!");

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1,7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format($"{dia:D2}/{mes:D2}/{ano:D4}");
            Console.WriteLine(formatarData(10,03,1995));
        }
    }
}
