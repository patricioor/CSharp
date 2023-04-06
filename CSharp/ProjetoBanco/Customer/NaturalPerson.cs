using System;

namespace ProjetoBanco.Customer
{
    public class NaturalPerson
    {
        public string Name {get; set;}
        string Street {get; set;}
        uint StreetNumber {get; set;}
        string CellPhone {get; set;}
        string Cpf {get; set;}
        uint Rg {get; set;}
        string Email{get;set;}

        public NaturalPerson (string name, string street, uint streetNumber, string cellPhone, string cpf, uint rg, string email) {
            Name = name;
            Street = street;
            StreetNumber = streetNumber;
            CellPhone = cellPhone;
            Cpf = cpf;
            Rg = rg;
            Email = email;
        }

        public NaturalPerson () {}
    }
}