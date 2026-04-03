using Microsoft.AspNetCore.Mvc;

namespace MayurkumarApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VerifyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // get runner name from docker env variable
            var runner = Environment.GetEnvironmentVariable("RUN_BY") ?? "RUN_BY not set";
            // create response object for /verify
            var response = new
            {
                builder = "Mayurkumar",
                runner = runner,
                timestamp = DateTime.UtcNow,
                machineName = Environment.MachineName
            };

            return Ok(response);
        }
    }
}