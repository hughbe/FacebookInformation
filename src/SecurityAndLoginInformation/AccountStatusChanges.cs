using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class AdministrativeRecords
    {
        [JsonProperty("admin_records")]
        public IReadOnlyList<AdministrativeRecord> All { get; set; }
    }
}
