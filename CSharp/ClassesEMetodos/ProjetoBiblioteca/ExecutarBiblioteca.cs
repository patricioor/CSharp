using System;

namespace Projeto_CSharp.ClassesEMetodos.ProjetoBiblioteca {
    class ExecutarBiblioteca
    {
        public static void Executar()
        {
            var biblioteca = new Biblioteca();

            int opcao = 0;

            do
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Cadastrar livro");
                Console.WriteLine("3 - Emprestar livro");
                Console.WriteLine("4 - Devolver livro");
                Console.WriteLine("5 - Listar todos os livros");
                Console.WriteLine("6 - Listar todas as pessoas cadastradas");
                Console.WriteLine("7 - Listar todos os livros emprestados");
                Console.WriteLine("0 - Encerrar a aplicação");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                    int qntLivrosEmprestadosUsuario = 0;
                        Console.WriteLine("Cadastrar Pessoa");
                        Console.Write("ID: ");
                        int.TryParse(Console.ReadLine(), out int idPessoa);
                        if (biblioteca.verificarIdPessoa(idPessoa))
                        {
                            Console.WriteLine("ID já cadastrado");
                            break;
                        }
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("CPF: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Pessoa Pessoas = new Pessoa(idPessoa, nome, cpf, telefone);
                        biblioteca.CadastrarPessoa(Pessoas);
                        Console.WriteLine("Cadastro finalizado!");
                        break;
                    case 2:
                        int saldoExplrs= 0, qntLivrosEmprestados=0, qntDevolvida = 0;
                        Console.WriteLine("Cadastrar Livro");
                        Console.Write("ID: ");
                        int.TryParse(Console.ReadLine(), out int idLivro);
                        if (biblioteca.verificarIdLivro(idLivro) != false)
                        {
                            Console.WriteLine("ID já cadastrado");
                            break;
                        }
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Editora: ");
                        string editora = Console.ReadLine();
                        Console.Write("Quantidade de exemplares: ");
                        int.TryParse(Console.ReadLine(), out int qtdExemplares);
                        Livro Livros = new Livro(idLivro, titulo, autor, editora, qtdExemplares, saldoExplrs, qntLivrosEmprestados, qntDevolvida);
                        biblioteca.CadastrarLivro(Livros);
                        Console.WriteLine("Cadastro finalizado!");
                        break;

                    case 3:
                        Console.WriteLine("Emprestar Livro");
                        Console.Write("Insira o ID da pessoa: ");
                        int.TryParse(Console.ReadLine(), out idPessoa);
                        if (!biblioteca.verificarIdPessoa(idPessoa))
                        {
                            Console.WriteLine("Pessoa não cadastrada.");
                            break;
                        }

                        Console.Write("Insira o ID do livro: ");
                        int.TryParse(Console.ReadLine(), out idLivro);
                        if (biblioteca.verificarIdLivro(idLivro) != true)
                        {
                            Console.WriteLine("Livro não cadastrado.");
                            break;
                        } else {
                        biblioteca.EmprestarLivroBiblioteca(idLivro, idPessoa);
                        Console.WriteLine($"O livro '{biblioteca.pegarTituloLivroPeloId(idLivro)}' foi emprestado para o(a) cliente '{biblioteca.pegarNomePessoaPeloId(idPessoa)}'.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Devolver Livro");
                        Console.Write("Insira o ID da pessoa: ");
                        int.TryParse(Console.ReadLine(), out idPessoa);
                        if (biblioteca.verificarIdPessoa(idPessoa) != true)
                        {
                            Console.WriteLine("Pessoa não cadastrada");
                            break;
                        }

                        Console.Write("Insira o ID do livro: ");
                        int.TryParse(Console.ReadLine(), out idLivro);
                        if (biblioteca.verificarIdLivro(idLivro) != true)
                        {
                            Console.WriteLine("Livro não cadastrado.");
                            break;
                        }

                        biblioteca.DevolverLivroBiblioteca(idLivro, idPessoa);
                        Console.WriteLine($"O livro '{biblioteca.pegarTituloLivroPeloId(idLivro)}' que estava com a pessoa '{biblioteca.pegarNomePessoaPeloId(idPessoa)}' foi devolvido com sucesso.");
                        break;

                    case 5:
                        foreach (Livro livro in biblioteca.Livros)
                        {
                            Console.WriteLine("Listar todos os livros cadastrados.");
                            Console.WriteLine("ID: {0}, Titulo: {1}, Autor: {2}, Editora: {3}, Exemplares Disponíveis: {4}.", livro.Id, livro.Titulo, livro.Autor, livro.Editora, livro.QuantidadeExemplares);
                        }
                        break;
                    case 6:
                        foreach (Pessoa pessoa in biblioteca.Pessoas)
                        {
                            Console.WriteLine("Listar todas as pessoas cadastradas.");
                            Console.WriteLine("ID: {0}, Nome:{1}, CPF:{2}, Telefone:{3}", pessoa.Id, pessoa.Nome, pessoa.CPF, pessoa.Telefone);
                        }
                        break;

                    case 7:
                        foreach (Pessoa pessoas in biblioteca.Pessoas)
                        {
                            if (pessoas.LivrosEmprestados.Count > 0)
                            {
                                foreach (Livro livro in pessoas.LivrosEmprestados)
                                {
                                    Console.WriteLine("ID: {0}, Titulo: {1}, Autor: {2}, Editora: {3}, Exemplares Emprestados: {4}, Cliente que alugou: {5}.", livro.Id, livro.Titulo, livro.Autor, livro.Editora, livro.QuantidadeExemplares, pessoas.Nome);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não há livros emprestados");
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("---FIM---");
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}
