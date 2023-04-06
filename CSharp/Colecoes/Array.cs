using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.Colecoes
{
    public class Array
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Patricio";
            alunos[1] = "Carol";
            alunos[2] = "Gustavo";
            alunos[3] = "Rafael";
            alunos[4] = "Matheus";

            foreach(var aluno in alunos) {
                System.Console.WriteLine(aluno);
            }

            double somatorioNotas = 0;
            double[] notas = {5.6, 4.6, 8.8, 10, 9};

            foreach(var nota in notas) {
                somatorioNotas += nota;
            }

            // /\ Funções diferentes para a mesma finalidade \/
            //for(var i = 0; i < notas.Length; i++) somatorioNotas += notas[i];

            double media = somatorioNotas / notas.Length;

            System.Console.WriteLine(media);

            char[] letras = {'A', 'b', 'C', 'd', 'E'};
            string palavra = new string (letras);
            System.Console.WriteLine(palavra);
        }
    }
}