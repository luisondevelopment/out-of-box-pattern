using Microsoft.AspNetCore.Mvc;
using Producer.Services;

namespace Producer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProduceController : Controller
    {
        private readonly ProducerService _producerService;

        public ProduceController(ProducerService producerService)
        {
            _producerService = producerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _producerService.Produce();
            return Ok();
        }
    }
}
