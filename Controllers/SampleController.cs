using LT.Microservices.Demo1.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly GreetingProvider _provider;

        public SampleController(GreetingProvider provider, MessageProvider messageProvider)
        {
            _provider = provider;
        }

        public IActionResult Get()
        {
            return Ok(new { Message = _provider.GetGreeting() });
        }
    }
}
