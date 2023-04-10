namespace CSharp.OO
{
    public class Comida // classe pai (genérica)
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }
    }
    public class Feijao : Comida
    {
        //public double Peso; Tornando-se uma subclasse de "Comida", herdará o atributo "Peso" tornando desnecessário a criação dentro de cada classe.
        public Feijao(double peso) : base(peso) { } // Utiliza o construtor da classe pai como base
    }

    public class Arroz : Comida
    {
        //public double Peso;
        public Arroz(double peso) : base(peso) { }
    }

    public class Carne : Comida
    {
        //public double Peso;
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Comida comida) // Criado um método genérico que receberá o tipo da classe Pai. Possibilitando a adaptação automática para as classes existentes
                                        //  E para as classe que serão criadas posteriormente
        {
            Peso += comida.Peso;
        }
        //public void Comer (Feijao feijao) 
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer (Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer (Carne carne) 
        //{
        //    Peso += carne.Peso;
        //}
    }
    internal class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new (0.1);
            //ingrediente1.Peso(0.1);
            var ingrediente2 = new Arroz(0.15);
            //ingrediente2.Peso(0.15);
            Carne ingrediente3 = new Carne(0.15);
            //ingrediente3.Peso(0.15);

            Pessoa cliente = new Pessoa();
            cliente.Peso = 90.5;

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Novo peso para cliente é:{cliente.Peso}");


        }
    }
}
