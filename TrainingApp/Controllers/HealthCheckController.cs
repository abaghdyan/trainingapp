using Microsoft.AspNetCore.Mvc;

namespace TrainingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get(string key)
        {
            _logger.LogInformation(key);
            var rnd = new Random();
            return Enumerable.Range(1, 5).Select(index => $"{rnd.Next()} ").ToArray();
        }
    }
}