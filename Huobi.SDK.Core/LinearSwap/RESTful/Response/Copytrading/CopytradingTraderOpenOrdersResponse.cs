using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderOpenOrdersResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderData> Data { get; set; }
    }
    
    public class OrderData
    {
        [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractCode { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public string Volume { get; set; }

        [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string MarginMode { get; set; }

        [JsonProperty("position_side", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionSide { get; set; }

        [JsonProperty("order_direction", NullValueHandling = NullValueHandling.Ignore)]
        public int OrderDirection { get; set; }

        [JsonProperty("lever", NullValueHandling = NullValueHandling.Ignore)]
        public int Lever { get; set; }

        [JsonProperty("avg_price", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgPrice { get; set; }

        [JsonProperty("avg_volume", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgVolume { get; set; }

        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public string Fee { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
}