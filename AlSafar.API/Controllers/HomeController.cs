using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return Ok("Hello World");
    }
}