

using System.Text.Json.Serialization;

namespace TreasureApi.Generator
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum MagicItemType
  {
    ARMOR_OR_SHIELD,
    WEAPONS,
    POTIONS,
    RINGS,
    RODS,
    SCROLLS,
    STAVES,
    WANDS,
    WONDROUS_ITEM
  }
}