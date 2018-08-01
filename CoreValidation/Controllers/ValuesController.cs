using CoreValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ValueModel model)
        {
            return Ok(model);
        }
    }
}