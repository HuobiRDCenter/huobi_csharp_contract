using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class MarketLiquidationOrdersResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiquidationOrderData> Data { get; set; }

        public class LiquidationOrderData
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("liquidation_time", NullValueHandling = NullValueHandling.Ignore)]
            public string LiquidationTime { get; set; }

            [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
            public string Side { get; set; }

            [JsonProperty("position_side", NullValueHandling = NullValueHandling.Ignore)]
            public string PositionSide { get; set; }

            [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
            public string Volume { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public string Amount { get; set; }

            [JsonProperty("bankrupt_price", NullValueHandling = NullValueHandling.Ignore)]
            public string BankruptPrice { get; set; }

            [JsonProperty("trade_turnover", NullValueHandling = NullValueHandling.Ignore)]
            public string TradeTurnover { get; set; }
        }
    }
}