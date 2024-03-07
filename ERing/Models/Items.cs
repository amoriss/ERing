using Newtonsoft.Json;

namespace ERing.Models;

public class Items
{
    public string Name { get; set; }

    [JsonProperty("image")]
    public string ImageUrl { get; set; }

}
