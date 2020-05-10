using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Server.DTOs;

namespace Server.Controllers
{
  [Route("api/[controller]")]
  public class ServerController : ControllerBase
  {
    [HttpGet]
    [ProducesResponseType(typeof(ResultDto), 200)]
    public ActionResult<string> HelloWorld()
    {
      return Ok(new {
        Message="Hello World"  
      });
    }
  }
}

