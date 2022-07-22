using System.Threading.Tasks;
using TreasureApi.Generator;

namespace TreasureApi.Selectors
{
  public interface ISelector
  {
    Task<object> GetMagicItemAsync(MagicItem magicItemSeed);
  }
}