using System;

namespace Projeto_CSharp.ClassesEMetodos.ProjetoBiblioteca {
    public class Livro
    {
        public int Id {get; set;}
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public string Editora {get; set;}
        public int QuantidadeExemplares {get; set;}

        public Livro(int idLivro, string titulo, string autor,string editora,int qtdExemplares, int saldoExplrs, int qntLivrosEmprestados, int qntDevolvida) {
            Id = idLivro;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            QuantidadeExemplares = qtdExemplares;
        }

        public void EmprestarLivro(int qntLivrosEmprestados) {
            QuantidadeExemplares -= qntLivrosEmprestados;     
        }

        public void DevolverLivro(int quantidadeDevolvida) {
          QuantidadeExemplares += quantidadeDevolvida;
        }
    }
}