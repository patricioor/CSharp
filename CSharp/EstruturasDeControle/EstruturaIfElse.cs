namespace Projeto_CSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);
            Console.WriteLine("Aluno possui um bom comportamento(s/n)");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 7) {
                if (nota >= 9 && bomComportamento) {
                    Console.WriteLine("Aluno aprovado e será convidado para participar da turma avançada");
                }
                else {
                    Console.WriteLine("Aluno está aprovado");
                }
            }
            else
                if (4 <= nota) {
                Console.WriteLine("Aluno está em recuperação");
            }
            else {
                Console.WriteLine("Aluno está reprovado");
            }
        }

    }
}
