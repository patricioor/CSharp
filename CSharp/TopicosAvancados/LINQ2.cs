using static CSharp.TopicosAvancados.LINQ1;

namespace CSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno {Nome = "Pedro", Idade = 18, Nota = 8.2},
                new Aluno {Nome = "Carol", Idade = 20, Nota = 9.8},
                new Aluno {Nome = "Patricio", Idade = 19, Nota = 10.0},
                new Aluno {Nome = "Xico", Idade = 25, Nota = 5.9},
                new Aluno {Nome = "Gustavo", Idade = 23, Nota = 6.7},
                new Aluno {Nome = "Gustavo", Idade = 24, Nota = 9.2},
                new Aluno {Nome = "Beltrano", Idade = 27, Nota = 7.4}
            };

            var patricio = alunos.Single(aluno => aluno.Nome.Equals("Patricio"));
            Console.WriteLine($"Nome: {patricio.Nome}, Idade: {patricio.Idade}, Nota: {patricio.Nota}");

            var gustavo = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Gustavo"));
            if (gustavo == null) Console.WriteLine("Nome não encontrado.");

            var gustavo2 = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Gustavo2"));
            if( gustavo2 == null ) Console.WriteLine("Nome não encontrado.");

            var beltrano = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Beltrano"));
            if (beltrano == null) Console.WriteLine("Nome não encontrado.");

            var exemploSkip = alunos.Skip(2).Take(4);
            Console.WriteLine(exemploSkip);

            var maiorNota = alunos.Max(alunos => alunos.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(alunos => alunos.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas.ToString("N2"));

            var mediaDaTurma = alunos.Average(alunos => alunos.Nota);
            Console.WriteLine(mediaDaTurma.ToString("N2"));

            var mediaDaTurmaAprovados = alunos.Where(a => a.Nota >= 7).Average(a => a.Nota);
            Console.WriteLine(mediaDaTurmaAprovados.ToString("N2"));

        }
    }
}
