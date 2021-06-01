

using System.Text.Json.Serialization;

namespace TreasureApi.Generator
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum PowerLevel
  {
    MINOR,
    MEDIUM,
    MAJOR
  }
}