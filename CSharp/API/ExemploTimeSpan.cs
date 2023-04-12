namespace CSharp.API
{
    internal class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 6, hours: 8, minutes: 25, seconds: 37);
            Console.WriteLine(intervalo);

            Console.WriteLine($"Convertendo o tempo declado em minutos: {intervalo.TotalMinutes}");

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(50);

            var tempo = chegada - largada; // resultado é dado em TimeSpan
            Console.WriteLine(tempo.GetType());

            Console.WriteLine("Duração da prova: {0}", tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8))); // atribuição por valor. É criado um novo TimeSpan, sem alterar o atual.
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(-8)));

            Console.WriteLine("ToString 1: {0}", intervalo.ToString("g"));
            Console.WriteLine("ToString 1: {0}", intervalo.ToString("G"));
            Console.WriteLine("ToString 1: {0}", intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds); // Passando um valor e convertendo para milissegundos.

        }
    }
}
