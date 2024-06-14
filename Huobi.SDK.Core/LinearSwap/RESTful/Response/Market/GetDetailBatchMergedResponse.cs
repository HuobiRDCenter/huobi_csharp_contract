using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class GetDetailBatchMergedResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetailBatchMerged> Ticks { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        public class DetailBatchMerged
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public string BusinessType { get; set; }

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public long Id { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public string Amount { get; set; }

            [JsonProperty("ask", NullValueHandling = NullValueHandling.Ignore)]
            public float[] Ask { get; set; }

            [JsonProperty("bid", NullValueHandling = NullValueHandling.Ignore)]
            public float[] Bid { get; set; }

            [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
            public string Open { get; set; }

            [JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
            public string Close { get; set; }

            [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Count { get; set; }

            [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
            public string High { get; set; }

            [JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)]
            public string Low { get; set; }

            [JsonProperty("vol", NullValueHandling = NullValueHandling.Ignore)]
            public string Vol { get; set; }

            [JsonProperty("number_of", NullValueHandling = NullValueHandling.Ignore)]
            public string NumberOf { get; set; }

            [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
            public long Ts { get; set; }
        }
    }
}