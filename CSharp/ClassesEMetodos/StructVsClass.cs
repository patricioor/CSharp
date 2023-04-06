using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos
{
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }
    public class StructVsClass
    {
        public static void Executar() {
            SPonto sponto1 = new SPonto {X = 2, Y = 3};
            SPonto copiaSPonto1 = sponto1; //Atribuição por Valor;
            sponto1.X = 5;

            System.Console.WriteLine("SPonto X: {0}, Y: {1}.", sponto1.X, sponto1.Y);
            System.Console.WriteLine("Cópia SPonto X: {0}, Y: {1}.", copiaSPonto1.X, copiaSPonto1.Y);
            
            
            CPonto cponto1 = new CPonto () {X = 5, Y = 7};
            CPonto copiaCPonto1 = cponto1; //Atribuição por Referência;
            cponto1.X = 9;

            System.Console.WriteLine("CPonto X: {0}, Y: {1}.",cponto1.X, cponto1.Y);
            System.Console.WriteLine("Cópia CPonto X: {0}, Y: {1}.", copiaCPonto1.X, copiaCPonto1.Y);

        }
    }
}