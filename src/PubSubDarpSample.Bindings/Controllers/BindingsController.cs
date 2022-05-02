using Microsoft.AspNetCore.Mvc;

namespace PubSubDarpSample.Bindings.Controllers
{
    [ApiController]
    public class BindingsController : Controller
    {

        private readonly ILogger<BindingsController> _logger;

        public BindingsController(ILogger<BindingsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/bindings")]
        public async Task<IActionResult> Bindings () 
        {
            return new OkResult();
        }
    }
}