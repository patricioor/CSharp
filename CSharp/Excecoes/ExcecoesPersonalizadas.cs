using Projeto_CSharp.ClassesEMetodos;

namespace CSharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("O número sorteado é menor que zero");
            }
            else if (valor % 2 == 1)
            {
                throw new ImparException("O número sorteado é ímpar");
            }
            else if(valor >10)
            {
                throw new ArgumentException("Ocorreu um erro inesperado");
            }
            return valor;

        }
        public static void Executar()
        {
            int i = 0;
            do
            {
                try
                {
                    Console.WriteLine(PositivoPar());
                }
                catch (NegativoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ImparException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("--Fim do Programa--");
                    i++;
                }
            } while (i < 10);
        }
    }
}
