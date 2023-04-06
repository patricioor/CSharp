using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro(){}
    }


    class Construtores{
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "z4";
            carro1.Ano = 2020;
            Console.WriteLine($"Fabricante: {carro1.Fabricante}, Modelo: {carro1.Modelo}, Ano: {carro1.Ano}.");

            var carro2 = new Carro ("Fiesta","Ford", 2015);
            Console.WriteLine($"Fabricante: {carro2.Fabricante}, Modelo: {carro2.Modelo}, Ano: {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Punto",
                Ano = 2015
            };
            Console.WriteLine($"Fabricante: {carro3.Fabricante}, Modelo: {carro3.Modelo}, Ano: {carro3.Ano}");
        } 
    }
}