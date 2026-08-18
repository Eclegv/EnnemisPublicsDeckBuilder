using System.Collections.Generic;
using Newtonsoft.Json.Linq;

internal class CardData
{
    internal dynamic Card {get; set; }
    internal string Type  {get; set; }
    internal JToken RawData  {get; set; }
}