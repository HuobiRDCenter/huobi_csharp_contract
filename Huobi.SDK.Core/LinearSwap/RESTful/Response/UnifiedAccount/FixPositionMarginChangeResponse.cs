using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount
{
    public class FixPositionMarginChangeResponse
    {
        
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public FixPositionMarginChange Data { get; set; }
        
        public class FixPositionMarginChange
        {
            [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderId { get; set; }

            [JsonProperty("client_order_id", NullValueHandling = NullValueHandling.Ignore)]
            public long ClientOrderId { get; set; }
        }
    }
}