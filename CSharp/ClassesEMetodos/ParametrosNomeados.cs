using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            System.Console.WriteLine("{0:D2}/{1:D2}/{2}",dia, mes, ano);
        }
        public static void Executar() {
            Formatar(mes: 25,dia: 03, ano: 2023);
        }
    }
}