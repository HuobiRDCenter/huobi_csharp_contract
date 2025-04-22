using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapPositionRiskLimitResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            [JsonProperty("contract_code")]
            public string ContractCode { get; set; }

            [JsonProperty("contract_type")]
            public string ContractType { get; set; }

            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            [JsonProperty("max_lever")]
            public string MaxLever { get; set; }

            [JsonProperty("maintenance_margin_rate")]
            public string MaintenanceMarginRate { get; set; }

            [JsonProperty("max_volume")]
            public string MaxVolume { get; set; }

            [JsonProperty("min_volume")]
            public string MinVolume { get; set; }
        }
    }
}