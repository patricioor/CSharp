using System;

namespace Projeto_CSharp.ClassesEMetodos.ProjetoBiblioteca {
    public class Biblioteca
    {
        public new List<Pessoa> Pessoas { get; set; }
        public new List<Livro> Livros { get; set; }

        public Biblioteca()
        {
            Pessoas = new List<Pessoa>();
            Livros = new List<Livro>();
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public bool verificarIdPessoa(int idPessoa)
        {
            if (Pessoas.Exists(p => p.Id == idPessoa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verificarIdLivro(int idLivro)
        {
            if (Livros.Exists(l => l.Id == idLivro))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string pegarTituloLivroPeloId(int idLivro)
        {
            return Livros.Find(l => l.Id == idLivro).Titulo;
        }


        public string pegarNomePessoaPeloId(int idPessoa)
        {
            return Pessoas.Find(p => p.Id == idPessoa).Nome;
        }


        public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
        {
            Livro livro = Livros.Find(i => i.Id == idLivro);
            Pessoa pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro != null && pessoa != null)
            {
                livro.EmprestarLivro(1);
                pessoa.AdicionarLivroLista(livro);

            }
        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
        {
            Livro livro = Livros.Find(i => i.Id == idLivro);
            Pessoa pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro != null && pessoa != null)
            {
                livro.DevolverLivro(1);
                pessoa.RemoverLivroLista(idLivro);
            }
        }
    }
}