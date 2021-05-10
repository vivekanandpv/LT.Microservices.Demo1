using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Demo1.Providers
{
    public class GreetingProvider : IProvider<string>
    {
        public string Get()
        {
            return "GreetingProvider";
        }
    }
}
