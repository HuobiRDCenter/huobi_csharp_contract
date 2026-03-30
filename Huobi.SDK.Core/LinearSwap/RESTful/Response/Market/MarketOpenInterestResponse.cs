using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class MarketOpenInterestResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OpenInterestData Data { get; set; }

        public class OpenInterestData
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public string Amount { get; set; }

            [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
            public string Volume { get; set; }

            [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
            public string Value { get; set; }

            [JsonProperty("trade_amount", NullValueHandling = NullValueHandling.Ignore)]
            public string TradeAmount { get; set; }

            [JsonProperty("trade_volume", NullValueHandling = NullValueHandling.Ignore)]
            public string TradeVolume { get; set; }

            [JsonProperty("trade_turnover", NullValueHandling = NullValueHandling.Ignore)]
            public string TradeTurnover { get; set; }
        }
    }
}