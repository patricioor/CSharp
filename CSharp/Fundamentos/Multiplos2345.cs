/*
    Pink e Cérebro dividem um apartamento e estão juntos 24h/d desde o começo da pandemia.
    Para passar o tempo, Pink cria problemas matemáticos para Cérebro resolver, o último
    deles foi uma lista de números com a seguite pergunta:
    Quantos números da lista são múltiplos de 2,3,4 e 5?

    
    Entrada:
    A primeira linha da entrada consiste em um inteiro N(1<= N <=1000), representando a
    quantia de números na lista de Pink
    
    A segunda linha con N inteiro Li(1<=Li<=100), representando os números da lista de Pink.

    Saída:
    Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. Observe a 
    formatação da saída nos exemplos, pois deve ser seguida rigorosamente.

    Exemplo de entrada:
    5
    2 5 4 20 10

    Exemplo de saída:
    4 Múltiplo(s) de 2
    0 Múltiplo(s) de 3
    2 Múltiplo(s) de 4
    3 Múltiplo(s) de 5
*/
namespace Projeto_CSharp.Fundamentos {
    class Multiplos2345 {
        public static void Executar() {
            int m2 = 0, m3 = 0, m4 = 0, m5 = 0;

            Console.WriteLine("Insira a quantidade de números que irá inserir: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 1 ^ n >= 1000) {
                Console.WriteLine("Número inválido");
                return;
            }
            else {
                int[] ListaPink = new int[n];
                for (int i = 0; i < n; i++) {
                    Console.WriteLine("Insira os números: ");
                    int.TryParse(Console.ReadLine(), out int Li);
                    if (Li <= 1 ^ Li >= 100) {
                        Console.WriteLine("Número inválido");
                        return;
                    }
                    else {
                        ListaPink[i] = Li;
                    }
                }
                for (int j = 0; j < ListaPink.Length; j++) {
                    if (ListaPink[j] % 2 == 0) m2++;
                    if (ListaPink[j] % 3 == 0) m3++;
                    if (ListaPink[j] % 4 == 0) m4++;
                    if (ListaPink[j] % 5 == 0) m5++;
                }
            }
            Console.WriteLine("{0} Múltiplo(s) de 2", m2);
            Console.WriteLine("{0} Múltiplo(s) de 3", m3);
            Console.WriteLine("{0} Múltiplo(s) de 4", m4);
            Console.WriteLine("{0} Múltiplo(s) de 5", m5);
        }
    }
}
