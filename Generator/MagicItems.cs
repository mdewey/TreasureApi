using System;

namespace TreasureApi.Generator
{

  public class MagicItemSelector
  {
    public MagicItem SelectItemType(PowerLevel level)
    {
      var rand = new Random().Next(1, 101);
      MagicItemType itemType = MagicItemType.WEAPONS;
      switch (level)
      {
        case PowerLevel.MINOR:
          switch (rand)
          {
            case int r when (r >= 1 && r <= 4):
              itemType = MagicItemType.ARMOR_OR_SHIELD;
              break;
            case int r when (r >= 5 && r <= 9):
              itemType = MagicItemType.WEAPONS;
              break;
            case int r when (r >= 10 && r <= 44):
              itemType = MagicItemType.POTIONS;
              break;
            case int r when (r >= 45 && r <= 81):
              itemType = MagicItemType.SCROLLS;
              break;
            case int r when (r >= 82 && r <= 91):
              itemType = MagicItemType.WANDS;
              break;
            case int r when (r >= 92 && r <= 100):
              itemType = MagicItemType.WONDROUS_ITEM;
              break;
            default:
              break;
          }

          break;
        case PowerLevel.MEDIUM:
          switch (rand)
          {
            case int r when (r >= 1 && r <= 10):
              itemType = MagicItemType.ARMOR_OR_SHIELD;
              break;
            case int r when (r >= 11 && r <= 20):
              itemType = MagicItemType.WEAPONS;
              break;
            case int r when (r >= 21 && r <= 30):
              itemType = MagicItemType.POTIONS;
              break;
            case int r when (r >= 31 && r <= 40):
              itemType = MagicItemType.RINGS;
              break;
            case int r when (r >= 41 && r <= 50):
              itemType = MagicItemType.RODS;
              break;
            case int r when (r >= 51 && r <= 65):
              itemType = MagicItemType.SCROLLS;
              break;
            case int r when (r >= 66 && r <= 68):
              itemType = MagicItemType.STAVES;
              break;
            case int r when (r >= 69 && r <= 83):
              itemType = MagicItemType.WANDS;
              break;
            case int r when (r >= 84 && r <= 100):
              itemType = MagicItemType.WONDROUS_ITEM;
              break;
            default:
              break;
          }

          break;
        case PowerLevel.MAJOR:
          switch (rand)
          {
            case int r when (r >= 1 && r <= 10):
              itemType = MagicItemType.ARMOR_OR_SHIELD;
              break;
            case int r when (r >= 11 && r <= 20):
              itemType = MagicItemType.WEAPONS;
              break;
            case int r when (r >= 21 && r <= 25):
              itemType = MagicItemType.POTIONS;
              break;
            case int r when (r >= 26 && r <= 35):
              itemType = MagicItemType.RINGS;
              break;
            case int r when (r >= 36 && r <= 45):
              itemType = MagicItemType.RODS;
              break;
            case int r when (r >= 46 && r <= 55):
              itemType = MagicItemType.SCROLLS;
              break;
            case int r when (r >= 56 && r <= 75):
              itemType = MagicItemType.STAVES;
              break;
            case int r when (r >= 76 && r <= 80):
              itemType = MagicItemType.WANDS;
              break;
            case int r when (r >= 81 && r <= 100):
              itemType = MagicItemType.WONDROUS_ITEM;
              break;
            default:
              break;
          }
          break;
        default:
          break;
      }

      return new MagicItem { Power = level, Type = itemType };
    }
  }
}