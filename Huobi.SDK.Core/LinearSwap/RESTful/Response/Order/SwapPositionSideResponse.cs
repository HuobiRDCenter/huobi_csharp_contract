using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapPositionSideResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapPositionSide> Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        
        public class SwapPositionSide
        {
            [JsonProperty("margin_account", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginAccount { get; set; }

            [JsonProperty("position_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string PositionMode { get; set; }
        }
    }
}