using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Response.Common
{
    public class SwapLiquidationOrdersResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapLiquidationOrders> Data { get; set; }
        
        public class SwapLiquidationOrders
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public long QueryId { get; set; }

            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
            public string Direction { get; set; }

            [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
            public string Offset { get; set; }

            [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Volume { get; set; }

            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Price { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Amount { get; set; }

            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
            public long CreatedAt { get; set; }
        }
    }
}