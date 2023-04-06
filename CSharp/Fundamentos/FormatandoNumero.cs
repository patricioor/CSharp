using System.Globalization;

namespace Projeto_CSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            // Formata o valor para ter apenas uma casa decimal
            Console.WriteLine(valor.ToString("f1"));
            // Formata o valor para a moeda do país o qual o PC está configurado
            Console.WriteLine(valor.ToString("C"));
            // Formata o valor para porcentagem
            Console.WriteLine(valor.ToString("P"));
            //Formata o valor para ter apenas duas casas
            Console.WriteLine(valor.ToString("#.##"));


            //Formata o valor para a moeda do país especificado no instanciamento do objeto
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C", cultura));

            //Formata o valor para adicionar "0" à esquerda até atingir uma certa quantidade de caracteres, contando com o tamanho números de casa que o valor já tem
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
