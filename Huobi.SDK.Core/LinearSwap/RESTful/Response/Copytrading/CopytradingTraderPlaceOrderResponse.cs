using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderPlaceOrderResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }
    
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public bool Data { get; set; }
    
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
}