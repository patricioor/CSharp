using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBanco.Customer
{
    public class Enterprise
    {
        string CorporateName {get; set;}
        uint Cnpj {get; set;}
        string CorporateStreet {get; set;}
        uint CorporateStreetNumber {get; set;}
        string CorporateEmail {get; set;}
        string Telephone {get; set;}

        public Enterprise (string corporateName,uint cnpj, string corporateStreet, uint corporateStreetNumber, string corporateEmail, string telephone) {
            CorporateName = corporateName;
            Cnpj = cnpj;
            CorporateStreet = corporateStreet;
            CorporateStreetNumber = corporateStreetNumber;
            CorporateEmail = corporateEmail;
            Telephone = telephone;
        }

        public Enterprise() {}
    }
}