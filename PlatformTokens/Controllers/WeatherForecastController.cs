using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformTokens.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Here is info message from our values controller.");
            _logger.LogDebug("Here is debug message from our values controller");
            _logger.LogWarning("Here is warn message from our values controller");
            _logger.LogError("Here is an error message from our values controller");

            return new string[] { "ether", "bitcoin" };
        }
    }
}
