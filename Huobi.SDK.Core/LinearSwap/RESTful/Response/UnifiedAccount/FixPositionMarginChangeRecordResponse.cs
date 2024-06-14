using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount
{
    public class FixPositionMarginChangeRecordResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<FixPositionMarginChangeRecord> Data { get; set; }
        
        public class FixPositionMarginChangeRecord
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public long QueryId { get; set; }

            [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderId { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public double Amount { get; set; }

            [JsonProperty("asset", NullValueHandling = NullValueHandling.Ignore)]
            public string Asset { get; set; }

            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public int Type { get; set; }

            [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
            public int Direction { get; set; }
        }
    }
}