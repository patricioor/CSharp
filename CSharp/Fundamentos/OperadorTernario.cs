namespace Projeto_CSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var faltas = 8;
            var faltasLimite = 10;
            var dentroFaltasLimite = faltasLimite <= faltas;
            
            var nota = 7.0;
            var resultado = nota >= 7 && dentroFaltasLimite ? "Aprovado" : nota < 7 && nota >= 4 && dentroFaltasLimite ? "Em reperação" : "Reprovado";
            Console.WriteLine("O Aluno está {0}!", resultado);

            var nota1 = 6.9;
            var resultado1 = nota1 >= 7 ? "Aprovado" : nota1 < 7 && nota1 >= 4 ? "Em reperação" : "Reprovado";
            Console.WriteLine("O Aluno está {0}!", resultado1);

            var nota2 = 3.9;
            var resultado2 = nota2 >= 7 ? "Aprovado" : nota2 < 7 && nota2 >= 4 ? "Em reperação" : "Reprovado";
            Console.WriteLine("O Aluno está {0}!", resultado2);
        }
    }
}

