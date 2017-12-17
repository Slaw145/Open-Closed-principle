using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ZipCode { get; set; }
        private double _myWallet;
        public double MyWallet { get => _myWallet; set => _myWallet = value; }

        public Client(ClientConstructor myconfiguration)
        {
            FirstName = myconfiguration.firstname;
            LastName = myconfiguration.lastname;
            ZipCode = myconfiguration.zipcode;
            _myWallet = myconfiguration.myWallet;
        }
    }
}
