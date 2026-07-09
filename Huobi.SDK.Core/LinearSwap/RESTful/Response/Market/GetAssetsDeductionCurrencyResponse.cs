using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class GetAssetsDeductionCurrencyResponse
    {
        public int code  { get; set; }

        public string message { get; set; }

        public long ts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Data data { get; set; }

        public class Data
        {
            [JsonProperty("currency")]
            public List<string> Currency { get; set; }
        }
    }
}