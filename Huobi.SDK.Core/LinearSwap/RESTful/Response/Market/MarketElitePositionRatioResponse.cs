using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class MarketElitePositionRatioResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ElitePositionRatioData> Data { get; set; }

        public class ElitePositionRatioData
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("buy_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public string BuyRatio { get; set; }

            [JsonProperty("sell_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public string SellRatio { get; set; }

            [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
            public string Ts { get; set; }
        }
    }
}