using Newtonsoft.Json;

namespace Huobi.SDK.Core.WSBase
{
    public class WSUnifiedOpData
    {
        public string op { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cid { get; set; }

        public string topic { get; set; }

        [JsonProperty("contract_code")]
        public string contractCode { get; set; }
    }
}
