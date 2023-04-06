using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CSharp.ClassesEMetodos {
    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;
        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    public class ExemploStruct
    {
        public static void Executar() {
            // var coordenadaInicial = new Coordenada(x: 2, y: 2);

            // /\ processo se fosse utilizado em uma Class (É necessária a inicialização por um construtor)  
            // \/ Processo sendo utilizado em struct (Não é necessária a inicialização por um construtor)

            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            System.Console.WriteLine("Coordenada Inicial:");
            System.Console.WriteLine("X = {0}", coordenadaInicial.X);
            System.Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 5,y: 3);
            coordenadaFinal.MoverNaDiagonal(3);
            System.Console.WriteLine("Coordenada Final:");
            System.Console.WriteLine("X = {0}", coordenadaFinal.X);
            System.Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}