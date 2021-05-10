using LT.Microservices.Demo1.Providers;
using LT.Microservices.Demo1.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly IEnumerable<IProvider<string>> _providers;
        private readonly IConfiguration configuration;

        public SampleController(IEnumerable<IProvider<string>> providers, IConfiguration configuration)
        {
            _providers = providers;
            this.configuration = configuration;
        }

        public IActionResult Get()
        {
            var person = configuration.GetSection("Person").Get<PersonViewModel>();
            return Ok(new { Message = person.FirstName, City = person.Address.City });
        }
    }
}
