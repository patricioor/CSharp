namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Instagram";

        //Herança
        protected string CorDosOlhos = "Verde";

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5585999999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Gírias";

        //Mesma Class ou Herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Segredo de Família";

        // private é o padrão quando não declarado
        bool UsaPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Acesso SubCelebridade");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaPhotoshop);
        }
    }
}
