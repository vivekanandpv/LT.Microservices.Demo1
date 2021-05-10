using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Demo1.Providers
{
    public class MessageProvider
    {
        public MessageProvider()
        {
            Console.WriteLine("MessageProvider created");
        }
        public string GetMessage()
        {
            return "Good afternoon!";
        }
    }
}
