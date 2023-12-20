using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.API.Controllers;
[ApiController]
[Route("api/home")]
public class Home : ControllerBase
{
    [HttpGet]
    public string Index()
    {
        return "Hello World";
    }
}