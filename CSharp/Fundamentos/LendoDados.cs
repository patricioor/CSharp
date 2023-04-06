using System.Globalization;

namespace Projeto_CSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            // Console.ReadLine() transforma o dado inserido em string por padrão. necessário assim fazera conversão
            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            // Por padrão o console levará em consideração a linguagem padrão da máquina.
            // VS code utiliza o sistema americano, e o console(nesta máquina) pt-br
            // Então para padronizar com o do vs code, utiliza-se o ",CultureInfo.InvariantCulture"(em conjunto com o "using System.Globalization;" para ignorar a "cultura" da máquina.
            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}.");
        }
    }
}
