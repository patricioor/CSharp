namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Acessos: Amigo Próximo");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos); Transmitido apenas por herança
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia); Transmitido apenas por herança e estando no mesmo projeto
            //Console.WriteLine(amigo.UsaPhotoshop); Disponível apenas classe.
        }
    }
}
