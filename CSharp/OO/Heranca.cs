namespace Projeto_CSharp.OO
{
    public class Heranca
    {
        public class Carro {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;

            public Carro(int velocidadeMaxima) {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta) {
                int novaVelocidade = VelocidadeAtual + delta;
                Console.Write(delta < 0 && VelocidadeAtual == 0 ? "O carro já está parado: ":null);
                Console.Write(delta > 0 && VelocidadeAtual >= 0 ? "O carro está acelerando: ":null);
                Console.Write(delta < 0 && VelocidadeAtual != 0 ? "O carro está desacelerando: ":null);
                if (novaVelocidade < 0) {
                    VelocidadeAtual = 0;
                } else
                    if (novaVelocidade > VelocidadeMaxima) {
                        VelocidadeAtual = VelocidadeMaxima;
                    } else {
                        VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;
            }

            public virtual int Acelerar() { //virtual possibilidade o override do método por um filho
                return AlterarVelocidade(5);
            }

            public int Frear() {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno: Carro {
            public Uno() : base(160) {} // : base () é utilizado quando a classe pai não possui um construtor padrão.
        }

        public class Ferrari: Carro {
            public Ferrari() : base(350) {}

            public override int Acelerar() {
                return AlterarVelocidade(15);
            }

            //Oculta o método da classe pai
            public new int Frear () {
                return AlterarVelocidade(-10);
            }
        }
        public static void Executar() {
            Console.WriteLine("Uno");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            System.Console.WriteLine("Ferrari");
            var carro2 = new Ferrari();
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            // Utilizando o Tipo Carro, a ferrari utilizará o método Acelerar que foi sobreescrito da classe Carro. 
            // Mas, usará o método "frear" da classe carro pois está não resgata o método criado na classe filha.
            System.Console.WriteLine("Ferrari com tipo Carro");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Acelerar());// 15
            Console.WriteLine(carro3.Acelerar());// 30
            Console.WriteLine(carro3.Frear());// 25
            Console.WriteLine(carro3.Frear());// 20
            Console.WriteLine(carro3.Frear());// 15
            Console.WriteLine(carro3.Frear());// 10

            System.Console.WriteLine("Uno com tipo Carro");
            carro3 = new Uno();
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}