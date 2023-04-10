using System.Globalization;

namespace CSharp.OO
{
    internal class Absctract
    {
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Trim trim trim..";
            }
        }

        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return "Olá! Meu nome é Bixby!";
            }
        }

        public class IPhone : Celular
        {
            public override string Assistente()
            {
                return "Olá! Meu nome é Siri!";
            }
        }
        public static void Executar()
        {
            var celulares = new List<Celular>() {
            new Samsung(),
            new IPhone()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
                Console.WriteLine(celular.Tocar());
            }
        }
    }
}
