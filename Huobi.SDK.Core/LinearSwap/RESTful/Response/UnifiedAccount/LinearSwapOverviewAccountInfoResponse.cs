using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount
{
    public class LinearSwapOverviewAccountInfoResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<LinearSwapOverviewAccountInfo> Data { get; set; }
        
        public class LinearSwapOverviewAccountInfo
        {
            [JsonProperty("margin_asset", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginAsset { get; set; }

            [JsonProperty("margin_balance", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginBalance { get; set; }

            [JsonProperty("margin_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginAvailable { get; set; }
        }
    }
}