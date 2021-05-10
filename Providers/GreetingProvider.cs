using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Demo1.Providers
{
    public class GreetingProvider
    {
        private readonly MessageProvider _messageProvider;

        public GreetingProvider(MessageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        public string GetGreeting()
        {
            return _messageProvider.GetMessage();
        }
    }
}
