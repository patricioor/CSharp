using Projeto_CSharp.Fundamentos;
using Projeto_CSharp.EstruturasDeControle;
using Projeto_CSharp.ClassesEMetodos;
using Projeto_CSharp.Colecoes;
using CSharp.OO;
using CSharp.MetodosEFuncoes;
using CSharp.Excecoes;
using CSharp.API;
using CSharp.TopicosAvancados;

namespace Projeto_CSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentários.Executar},
                {"Variáveis e Constantes - Fundamentos", VariáveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do-While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break; - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue; - Estruturas de Controle", UsandoContinue.Executar },

                // Classes & Métodos
                {"Membros: Atributos e Métodos - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Parâmetros - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"ExemploEnum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Class vs Struct - Classes e Métodos", StructVsClass.Executar},
                {"Valor vs Referência- Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência- Classes e Métodos", ParametrosPorReferencia.Executar},

                
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", List.Executar},
                {"ArrayList - Coleções", ArrayList.Executar},
                {"Set - Coleções", Set.Executar},
                {"Queue - Coleções", Queue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", Stack.Executar},
                {"Dicionário - Coleções", Dictionary.Executar},
                
                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor 'This' - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", CSharp.OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Absctract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed- Orientação a Objetos", Sealed.Executar},

                //Métodos e Funções
                {"Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda como Delegate - Métodos e Funções", LambdaDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate como Função Anônima - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegates como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},


                //Exceções
                {"Primera Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //API
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                //Tópicos Avançados
                {"Lenguage INtegrated Query #01 - Tópicos Avançados", LINQ1.Executar},
                {"Lenguage INtegrated Query #02 - Tópicos Avançados", LINQ2.Executar},
                {"Nullable - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Genéricos - Tópicos Avançados", Genericos.Executar},


                //Exercícios
                {"Exercício: Múltiplos de 2,3,4 e 5", Multiplos2345.Executar },
                {"Exercício: Número primo", NumeroPrimo.Executar },
                {"Exercício: Menor Diferença - Estruturas de Controle", ExercicioMenorDiferenca.Executar },
                {"Projeto: Biblioteca", ClassesEMetodos.ProjetoBiblioteca.ExecutarBiblioteca.Executar },
                {"Projeto: Banco Simples", ProjetoBanco.TerminalBanco.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
