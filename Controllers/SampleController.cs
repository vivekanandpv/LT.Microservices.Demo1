using LT.Microservices.Demo1.Providers;
using LT.Microservices.Demo1.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LT.Microservices.Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IEnumerable<IProvider<string>> _providers;
        private PersonViewModel _viewModel;

        public SampleController(IEnumerable<IProvider<string>> providers, IOptionsMonitor<PersonViewModel> options)
        {
            _providers = providers;
            this._viewModel = options.CurrentValue;
            options.OnChange((vm) =>
            {
                Console.WriteLine("Value change detected");
                this._viewModel = vm;
            });
        }

        public IActionResult Get()
        {
            Thread.Sleep(10000);
            return Ok(new { Message = _viewModel.FirstName, City = _viewModel.Address.City });
        }
    }
}
