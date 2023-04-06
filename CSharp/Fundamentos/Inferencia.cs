namespace Projeto_CSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Patrício"; // == string nome = "Patrício";
            // nome = 123; ~ Apresentarar um erro pois após a inicialização com um tipo, string no caso, a variável só aceitará dados do mesmo tipo
            Console.WriteLine(nome);

            int idade = 32;
            //var idade = 32; dará erro ao tentar utilizar o "var" após a inicialização, pois apresentará uma duplicidade de variáveis.
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;
            Console.WriteLine(a + b);
        }
    }
}
