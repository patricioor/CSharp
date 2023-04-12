namespace CSharp.TopicosAvancados
{
    internal class Nullables
    {
        static int num3; // variáveis a nível de classe são inicializadas por padrão
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;
            //int num3 = null; Não é possível converter um valor nulo para int.

            if(num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            } else
            {
                Console.WriteLine("A variável não possui valor");
            }

            int valor = num1 ?? 1000; // Caso o valor de num1 seja "null", será substituído pelo número a direita do operador "??", no caso, 1000.
            Console.WriteLine(valor); //1000

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();// Caso não seja inserido nenhum parâmetro entre os parênteses, será atribuído o valor padrão para o tipo, no caso, "false".

            try
            {
                int x = num1.Value; // Neste exemplo há uma navegação segura. Gerará o erro na conversão do valor null para int. Retirar a extensão ".Value" e substituir  
                int y = num2.Value; // por ".GetValurOrDefault()" resolvera o erro. 
                Console.WriteLine(x + y);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
