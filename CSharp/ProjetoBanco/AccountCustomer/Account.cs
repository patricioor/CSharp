using System;
using ProjetoBanco.Customer;

namespace ProjetoBanco.AccountCustomer
{
    public class Account
    {
        uint Agency {get; set;}
        uint AccountNumber {get; set;}
        string AccountType {get; set;}
        public Enterprise Enterprise {get; set;}
        public NaturalPerson NaturalPerson {get; set;}        
        Decimal Balance {get; set;}

        public Account (uint agency, uint accountNumber, string accountType, Decimal balance) {
            Agency = agency;
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
        }

        public Account () {}

        public Decimal ShowBalance() {
            return Balance;
        }

        public Decimal Depositar(uint value) {
            return Balance += value;
        }

        public void Sacar(uint value) {
            if(value <= Balance && value >= 0) {
                Balance -= value;
            } else {
                System.Console.WriteLine("O valor para saque é maior que o valor disponível na conta");
            }
        }
    }
}