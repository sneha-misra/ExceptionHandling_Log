using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        [Route("[Action]")]
        public IActionResult GetDetails()
        {
            return Ok(GetDeatils());

        }

        private object GetDeatils()
        {
            throw new NotImplementedException();
        }
    }
}
