using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        public LogController(ILoggerManager logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult Get()
        {
            _logger.LogInfo("Here is info message from the controller.");
            _logger.LogDebug("Here is debug message from the controller.");
            _logger.LogWarn("Here is warn message from the controller.");
            _logger.LogError("Here is error message from the controller.");
            return Ok(new string[] { "log1", "log2" });
        }
    }
}
