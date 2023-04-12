using System;
using System.Linq;

namespace CSharp.TopicosAvancados
{
    internal class LINQ1
    {
        public class Aluno
        {
            public string Nome;
            public int Idade;
            public double Nota;
        }
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno {Nome = "Pedro", Idade = 18, Nota = 8.2},
                new Aluno {Nome = "Carol", Idade = 20, Nota = 9.8},
                new Aluno {Nome = "Patricio", Idade = 19, Nota = 10.0},
                new Aluno {Nome = "Xico", Idade = 25, Nota = 5.9},
                new Aluno {Nome = "Manel", Idade = 23, Nota = 6.7},
                new Aluno {Nome = "Gustavo", Idade = 24, Nota = 9.2},
                new Aluno {Nome = "Beltrano", Idade = 27, Nota = 7.4}
            };

            Console.WriteLine("===== Aprovados =====");
            var aprovados = alunos.OrderByDescending(a => a.Nota).Select((value, index) => new { value, index });
            foreach (var aluno in aprovados)
            {
                Console.WriteLine($"{aluno.index + 1}º: Nome: {aluno.value.Nome}, Nota: {aluno.value.Nota}");
            }
            //var aprovados = alunos.Where(a => a.Nota >= 7).OrderByDescending(a => a.Nota);
            //foreach (var aluno in aprovados.Select((value, index) => new {value, index}))
            //{
            //    Console.WriteLine($"{aluno.index + 1}º: Nome: {aluno.value.Nome}, Nota: {aluno.value.Nota}");
            //}

            Console.WriteLine("\n==== Lista de Presença ====");
            var presenca = alunos.OrderBy(a => a.Nome).Select(a=> a.Nome);
            foreach(var aluno in presenca) Console.WriteLine(aluno);

            Console.WriteLine("==== Aprovados por Idade ====");
            var alunosAprovados =
                from aluno in alunos where aluno.Nota >= 7 orderby aluno.Idade descending select aluno.Nome;
            foreach(var aluno in alunosAprovados) Console.WriteLine(aluno);
        }
    }
}
