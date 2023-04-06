namespace Projeto_CSharp.Fundamentos {
    class VariáveisEConstantes {
        public static void Executar() {
            //área da circunferência
            double raio;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1416;

            double area = PI * raio * raio;
            Console.WriteLine("Área do circulo");
            Console.WriteLine("Área é: " + area);

            // Tipos internos

            bool estaChovendo = true; // ou false
            Console.WriteLine("Está chovendo? " + estaChovendo);

            //byte = 8 bits, só aceitará armazenar apenas valores de 0 até 255
            byte idade = byte.MaxValue;
            Console.WriteLine("Idade: " + idade);

            //sbyte = mesma regra do byte, mas aceita números negativos. Só aceita armazenar números de -128 até 127.
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            //short = 16 bits, só armazena números de -32768 até 32767
            short salario = short.MinValue;
            Console.WriteLine("Salário é: R$ " + salario + ",00");

            //int = 32 bits, aceita armazenar números de -2147483648 até 2147483647. É o mais usado para números inteiros.
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor que o int aceita: " + menorValorInt);

            //uint, terá um papel semelhante ao do byte. Aceitará apenas apenas valores de 0 até o número 4294967295.
            uint maxValorUInt = 4_294_967_295;
            Console.WriteLine("Maior valor que 'uint' pode receber: " + maxValorUInt);

            //long = 64 bits, aceita armazenar números de -9223372036854775808 até 9223372036854775807.
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor aceito pela variável 'long': " + menorValorLong);

            //ulong, terá um papel semelhante ao do byte. Aceitará apenas valores de 0 até 18446744073709551615.
            ulong maiorValorLong =  ulong.MaxValue;
            Console.WriteLine("Maior valor aceito por 'ulong': " + maiorValorLong);

            //float = 32 bits, tem o papel de receber números com ponto flutuante. Necessita colocar o 'f' no final do número.
            float precoCarro = 59999.99f;
            Console.WriteLine("Preço do carro: R$ " + precoCarro);

            //double = 64bits, tem o papel de receber números com ponto flutuante. Não necessita colocar o 'f' no final do número.
            double valorDeMercadoTesla = 1_000_000_000_000.25;
            Console.WriteLine("Valor de mercado da empresa Tesla em reais: R$" + valorDeMercadoTesla);

            decimal menorDistanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Menor distância entre duas estrelas(KM): " + menorDistanciaEntreEstrelas);

            //char, recebe até um caractere.
            char opcao = 'A';
            Console.WriteLine("Letra '" +  opcao +"'");

            //string, um vetor de char concatenado.
            string saudacao = "Oi, mundo";
            Console.WriteLine(saudacao);
        }
    }
}
