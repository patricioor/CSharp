using System;


namespace Projeto_CSharp.ClassesEMetodos
{   
    public class CarroOpcional {
        double desconto = 0.1;
        string nome;
        public string Nome {get{ return nome;} set { nome = value;}}

        // Propriedade Autoimplementadas
        public double Preco {get; set;}

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // = get{ return Preco - (desconto * Preco);}
        }

        public CarroOpcional () {}

        public CarroOpcional ( string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    public class Props
    {
        public static void Executar(){
            var op1 = new CarroOpcional ("Direção Hidráulica", 3000.51);
            
            System.Console.WriteLine("Nome do Produto: {0}", op1.Nome);
            System.Console.WriteLine($"Preço do Produto: {op1.Preco}");
            System.Console.WriteLine("Orçamento Final: R$ " + op1.PrecoComDesconto.ToString("N2"));

            var op2 = new CarroOpcional ();
            op2.Nome = "Ar-Condicionado";
            op2.Preco = 2000.00;

            System.Console.WriteLine($"Nome do Produto: {op2.Nome}");
            System.Console.WriteLine("Preço do Produto: {0}", op2.Preco);
            System.Console.WriteLine("Orçamento Final: R$ " + op2.PrecoComDesconto.ToString("N2"));
            
        }
    }
}