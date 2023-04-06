using Encapsulamento;

namespace CSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Acessos: Filho não reconhecido");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular); Apenas dentro do mesmo projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia); Apenas por herança e dentro do mesmo projeto
            //Console.WriteLine(UsaPhotoshop); Apenas na classe
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("Acessos: Amigo distante");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos); Transmitido apenas por herança
            //Console.WriteLine(amigo.NumeroCelular); Transmitido apenas dentro do mesmo projeto
            //Console.WriteLine(amigo.JeitoDeFalar); Transmitido apenas por herança ou mesmo projeto
            //Console.WriteLine(amigo.SegredoFamilia); Transmitido apenas por herança e mesmo projeto
            //Console.WriteLine(amigo.UsaPhotoshop); Disponível apenas na classe
        }
    }
    public class Encapsulamento
    {
        public static void Executar()
        {
            Console.WriteLine("Acessos");
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            Console.WriteLine("-----");

            Console.WriteLine("Está no mesmo Projeto e Herda");
            new FilhoReconhecido().MeusAcessos();
            Console.WriteLine("-----");
            Console.WriteLine("Está no mesmo projeto e instancia");
            new AmigoProximo().MeusAcessos();
            Console.WriteLine("-----");
            Console.WriteLine("Não está no mesmo projeto e herda");
            new FilhoNaoReconhecido() .MeusAcessos();
            Console.WriteLine("-----");
            Console.WriteLine("Não está no mesmo projeto e instancia");
            new AmigoDistante().MeusAcessos();
        }
    }
}
