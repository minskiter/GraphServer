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
        public IEnumerable<ResultDto> HelloWorld()
        {
            List<ResultDto> list = new List<ResultDto>();
            list.Add(new ResultDto {
                title = "A Title",
                url = "https://umrninside.github.io/vue-cli/fhxtest/1.jpg"
            });
            list.Add(new ResultDto {
                title = "Title 2",
                url = "https://umrninside.github.io/vue-cli/fhxtest/2.jpg"
            });
            return list;
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
