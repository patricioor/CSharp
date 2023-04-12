using Projeto_CSharp.ClassesEMetodos;

namespace CSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }
        public Caixa (T coisa)
        {
            Coisa = coisa;
            this.valorPrivado = valorPrivado;
        }
        public T metodoGenerico(T valor)
        {
            return new Random().Next(0,2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto()) { }
    }
    internal class Genericos
    {
        public static void Executar()
        {
            int i = 0;
            while (i <= 5)
            {
                var caixa1 = new Caixa<int>(1000);
                Console.WriteLine(caixa1.metodoGenerico(33));
                i++;

                var caixa2 = new Caixa<string>("Construtor");
                Console.WriteLine(caixa2.metodoGenerico("Método"));

                CaixaProduto caixa3 = new CaixaProduto();
                Console.WriteLine(caixa3.Coisa.GetType().Name);
            }
        }
    }
}
