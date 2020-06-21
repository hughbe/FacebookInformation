using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class MenuItemsInteractions
    {
        [JsonProperty("menu_items")]
        public IReadOnlyList<Interaction> All { get; set; }
    }
}
