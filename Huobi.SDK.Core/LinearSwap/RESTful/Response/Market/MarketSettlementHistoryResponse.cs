using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class MarketSettlementHistoryResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SettlementHistoryData> Data { get; set; }

        public class SettlementHistoryData
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("settlement_time", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementTime { get; set; }

            [JsonProperty("clawback_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public string ClawbackRatio { get; set; }

            [JsonProperty("settlement_price", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementPrice { get; set; }
        }
    }
}