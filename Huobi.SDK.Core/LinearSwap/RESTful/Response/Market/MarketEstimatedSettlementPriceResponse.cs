using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class MarketEstimatedSettlementPriceResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<EstimatedSettlementPriceData> Data { get; set; }

        public class EstimatedSettlementPriceData
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("settlement_type", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementType { get; set; }

            [JsonProperty("estimated_settlement_price", NullValueHandling = NullValueHandling.Ignore)]
            public string EstimatedSettlementPrice { get; set; }
        }
    }
}