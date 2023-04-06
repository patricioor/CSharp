using System;
using System.Collections.Generic;

namespace Projeto_CSharp.ClassesEMetodos.ProjetoBiblioteca {
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }

        public Pessoa(int idPessoa, string nome, string cpf, string telefone)
        {
            Id = idPessoa;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            LivrosEmprestados = new List<Livro>();
        }

        public void AdicionarLivroLista(Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }

        public void RemoverLivroLista(int idLivro)
        {
            LivrosEmprestados.RemoveAll(l => l.Id == idLivro);

        }
    }
}
