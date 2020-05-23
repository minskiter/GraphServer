using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Server.DTOs;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ResultDto), 200)]
        public ActionResult<ResultDto> HelloWorld()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(9);
            list.Add(1);
            list.Add(9);
            list.Add(8);
            list.Add(1);
            list.Add(0);
            return Ok(new {
                    Message="Hello World",
                    List=list
            });
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResultDto), 200)]
        public ActionResult<ResultDto> BeastId(long id)
        {
            return Ok(new {
                Id=id,
                Message=$"Hello, user {id} !"
            });
        }
    }
}

