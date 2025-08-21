using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
[Route(template:"api/[controller]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    [HttpGet("sum")]
    public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
    {
        var result = a + b;
        return Ok(new { a, b, result });
    }
}
   
}
