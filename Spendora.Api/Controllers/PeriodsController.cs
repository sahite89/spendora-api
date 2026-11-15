using Microsoft.AspNetCore.Mvc;

namespace Spendora.Api.Controllers
{
    [ApiController]
    [Route("api/v1/periods")]
    public class PeriodsController : ControllerBase
    {
        [HttpGet("{period}/summary")]
        public IActionResult GetSummary(string period)
        {
            return Ok("Periods API is working!");
        }
    }
}
