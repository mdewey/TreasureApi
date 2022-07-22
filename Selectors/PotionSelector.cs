using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using TreasureApi.Generator;

namespace TreasureApi.Selectors
{
  public class PotionSelector : ISelector
  {
    static readonly HttpClient client = new HttpClient();

    public async Task<object> GetMagicItemAsync(MagicItem magicItemSeed)
    {

      var url = $"https://www.d20pfsrd.com/magic-items/potions";
      Console.WriteLine(url);
      var response = await client.GetAsync(url);
      response.EnsureSuccessStatusCode();
      string responseBody = await response.Content.ReadAsStringAsync();
      var htmlDoc = new HtmlDocument();
      htmlDoc.LoadHtml(responseBody);
      var data = htmlDoc
        .DocumentNode
        .SelectSingleNode("")
        .ChildNodes
        .Where(w =>
        {
          return !String.IsNullOrEmpty(w.InnerHtml.Trim());
        }).ToList();
      var i = 0;
      data.ForEach((node) => Console.WriteLine($"{i++} = { node.InnerHtml}"));

      return null;


    }
  }
}