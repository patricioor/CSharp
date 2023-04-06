/*
    Ao tentar elaborar uma partida beneficente e bem atrativa, a CBF solicitou a sua equipe de TI
    que idealizasse um modelo que calculasse dois times com a menor diferença em saldo de gols, 
    com base nos 5 primeiro colocados no campeonato brasileiro do ano anterior.
    
    O programa deverá identificar a menor diferença entre dois elementos e separar esses elementos
    em uma lista.

    Entrada [4,2,7,6,9]
    
    Saída[7,6]
 */
namespace Projeto_CSharp.EstruturasDeControle {
    internal class ExercicioMenorDiferenca {
        public static void Executar() {
            int[] timesFutebol = new int[5] {4,2,7,6,9};
            int[] timeFinal = new int[2];
            int saldoDeGols;
            int menorSaldoDeGols = int.MaxValue;

            for(int i = 0; i < timesFutebol.Length; i++) {
                for(int j = i+1; j < timesFutebol.Length; j++) {
                    saldoDeGols = timesFutebol[i] - timesFutebol[j];

                    if (saldoDeGols < 0) saldoDeGols = -saldoDeGols;
                    if (saldoDeGols < menorSaldoDeGols) {
                        menorSaldoDeGols = saldoDeGols;
                        timeFinal[0] = timesFutebol[i];
                        timeFinal[1] = timesFutebol[j];
                    }
                }
            }
            Console.WriteLine("O jogo beneficente será entre os times `{0} x {1}", timeFinal[0], timeFinal[1]);
        }
    }
}
