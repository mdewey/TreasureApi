using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreasureApi.Generator;
using TreasureApi.Selectors;

namespace TreasureApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TreasureController : ControllerBase
  {


    [HttpGet]
    public async Task<ActionResult> GetTreasure([FromQuery] int? minor, [FromQuery] int? medium, [FromQuery] int? major)
    {

      // generate minor + major + med number of random numbers
      var total = minor.GetValueOrDefault() + medium.GetValueOrDefault() + major.GetValueOrDefault();
      var numbers =
            new List<int>();
      var loots = new List<MagicItem>();
      for (var i = 0; i < minor; i++)
      {
        loots.Add(new MagicItemSelector().SelectItemType(PowerLevel.MINOR));
      }
      for (var i = 0; i < medium; i++)
      {
        loots.Add(new MagicItemSelector().SelectItemType(PowerLevel.MEDIUM));

      }
      for (var i = 0; i < major; i++)
      {
        loots.Add(new MagicItemSelector().SelectItemType(PowerLevel.MAJOR));
      }

      await new PotionSelector().GetMagicItemAsync(null);


      return Ok(new { parameters = new { minor, medium, major }, data = new { loots, numbers, total } });
    }
  }
}