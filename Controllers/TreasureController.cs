using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TreasureApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TreasureController : ControllerBase
  {


    [HttpGet]
    public async Task<ActionResult> GetTreasure([FromQuery] int? minor, [FromQuery] int? medium, [FromQuery] int? major)
    {
      return Ok(new { parameters = new { minor, medium, major } });
    }
  }
}