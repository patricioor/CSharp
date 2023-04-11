
namespace CSharp.Excecoes
{
    public class Conta
    {
        public double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }
    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_233.45);

            try
            {
                conta.Sacar(1400);
                Console.WriteLine("Saque efetuado com sucesso!");
            } catch (Exception ex) // Pode ser utilizado o "ArgumentException" no lugar do Exception para tratar um erro específico.
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("--Fim do Programa--");
            }
        }
    }
}
