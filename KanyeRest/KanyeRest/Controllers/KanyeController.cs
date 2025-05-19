using KanyeRest.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace KanyeRest.Controllers
{
    [ApiController]
    [Route("kanye")]
    public class KanyeController : ControllerBase
    {        
        public KanyeController()
        {

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(KanyeResponse))]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("age")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public IActionResult GetAge()
        {
            return Ok();
        }

        [HttpGet("name")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult GetName() 
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult GetBio() 
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult GetRandomQuote()
        {
            return Ok();
        }
    }
}
