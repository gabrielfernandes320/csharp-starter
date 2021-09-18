using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_template.src.modules.user.infra.ef.entities;
using csharp_template_v1._0;
using csharp_template_v1._0.src.shared.infra.ef.contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace csharp_template._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
       

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ICollection<User> Get()
        {
            using Context context = new();

            return context.Users.Select((u) => u).ToList();

        }
    }
}
