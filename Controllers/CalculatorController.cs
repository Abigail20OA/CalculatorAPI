using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new { a, b, result });
        }

        [HttpGet("sub")]
        public IActionResult GetSub([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new { a, b, result });
        }

        [HttpGet("mul")]
        public IActionResult GetMul([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new { a, b, result });
        }

        [HttpGet("div")]
        public IActionResult GetDiv([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0) return BadRequest(new { message = "No se puede dividir entre 0" });
            double result = (double)a / b;
            return Ok(new { a, b, result });
        }
    }
}