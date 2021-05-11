using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Demo1.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Console.WriteLine("PersonViewModel");
        }

        public string FirstName { get; set; }
        public AddressViewModel Address { get; set; }
    }

    public class AddressViewModel
    {
        public string City { get; set; }
    }
}
