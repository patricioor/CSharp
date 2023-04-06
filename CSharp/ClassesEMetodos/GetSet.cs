using System;

namespace Projeto_CSharp.ClassesEMetodos
{
    public class Moto {
        string Marca;
        string Modelo;
        ushort Cilindrada;

        public Moto (string marca, string modelo, ushort cilindrada) {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {}
        
        public string GetMarca () {
            return Marca;
        }

        public void SetMarca (string marca) {
            Marca = marca;
        }

        public string GetModelo () {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public ushort GetCilindrada () {
            return Cilindrada;
        }

        public void SetCilindrada(ushort cilindrada) {
            Cilindrada = (ushort) Math.Abs(cilindrada);
        }
    }
    public class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto ("Honda", "CG", 150);
            System.Console.WriteLine(moto1.GetMarca() + " " + moto1.GetModelo() + " " + moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Yamaha");
            moto2.SetModelo("WR250F");
            moto2.SetCilindrada(200);
            System.Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}