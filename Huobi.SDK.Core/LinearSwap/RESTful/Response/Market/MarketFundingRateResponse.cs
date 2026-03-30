using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class MarketFundingRateResponse
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
        public List<DataBean> Data { get; set; }

        public class DataBean
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("funding_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string FundingRate { get; set; }

            [JsonProperty("funding_time", NullValueHandling = NullValueHandling.Ignore)]
            public string FundingTime { get; set; }

            [JsonProperty("next_funding_time", NullValueHandling = NullValueHandling.Ignore)]
            public string NextFundingTime { get; set; }

            [JsonProperty("min_funding_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string MinFundingRate { get; set; }

            [JsonProperty("max_funding_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string MaxFundingRate { get; set; }
        }
    }
}