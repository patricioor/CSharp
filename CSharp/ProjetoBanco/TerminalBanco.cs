using ProjetoBanco.Customer;
using ProjetoBanco.AccountCustomer;
using System;

namespace Projeto_CSharp.ProjetoBanco {
    class TerminalBanco {
        public static void Executar() {
            

            var account = new Account(001, 1000, "Natural Person",0);
            
            account.NaturalPerson = new NaturalPerson ("Xico","Xico Street", 50, "99_9999_9999", "00000000011", 0001, "xico@xico.com");

            System.Console.WriteLine(account.ShowBalance());

            System.Console.WriteLine("Informações do Cliente:");
            System.Console.WriteLine($"Nome: {account.NaturalPerson.Name}"); // Acessível apenas após a mudança no nível de proteção

            account.Depositar(200);
            System.Console.WriteLine(account.ShowBalance());
            account.Sacar(100);
            System.Console.WriteLine(account.ShowBalance());
            account.Sacar(500);

            System.Console.ReadKey();

        }
    }
}
