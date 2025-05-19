using KanyeRest.Application.Services;
using KanyeRest.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace KanyeRest.Controllers
{
    [ApiController]
    [Route("kanye")]
    public class KanyeController : ControllerBase
    {
        private readonly IKanyeService _kanyeService;

        public KanyeController(IKanyeService kanyeService)
        {
            _kanyeService = kanyeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(KanyeResponse))]
        public IActionResult Get()
        {
            var info = _kanyeService.GetInfo();

            return Ok(info);
        }

        [HttpGet("age")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public IActionResult GetAge()
        {
            var info = _kanyeService.GetInfo();

            return Ok(info.Age);
        }

        [HttpGet("name")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult GetName()
        {
            var info = _kanyeService.GetInfo();

            return Ok(info.Name);
        }

        [HttpGet("bio")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult GetBio() 
        {
            var info = _kanyeService.GetInfo();

            return Ok(info.Biography);
        }

        [HttpGet("quote")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<IActionResult> GetRandomQuote()
        {
            var quote = await _kanyeService.GetQuoteAsync();

            return Ok(quote);
        }
    }
}
