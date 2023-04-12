namespace CSharp.API
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2004, month: 08, day: 02);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);


            // Sem Hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com Hora
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine("Hora: " + agora.Hour);
            Console.WriteLine("Minutos: " + agora.Minute);

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(agora.ToString("dd"));
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("D"));
            Console.WriteLine(agora.ToString("g"));
            Console.WriteLine(agora.ToString("G"));

        }
    }
}
