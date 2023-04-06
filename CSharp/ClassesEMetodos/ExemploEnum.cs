using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos{

    public enum Genero{ Acao, Aventura, Comedia, Drama, Romance, Terror};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;

    }
    public class ExemploEnum
    {
        public static void Executar() {
            int id = (int) Genero.Acao;
            System.Console.WriteLine(id);

            var filmeParaFamilia = new Filme();

            filmeParaFamilia.Titulo = "O caso do FON";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            System.Console.WriteLine($"O filme '{filmeParaFamilia.Titulo}' é do gênero : {filmeParaFamilia.GeneroDoFilme}.");
        }
    }
}