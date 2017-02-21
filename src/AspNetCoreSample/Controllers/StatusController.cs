using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSample.Controllers {

    [Route("_status")]
    public class StatusController : Controller {
        [HttpGet]
        public IActionResult Get(int id) {
            return Ok();
        }
    }
}