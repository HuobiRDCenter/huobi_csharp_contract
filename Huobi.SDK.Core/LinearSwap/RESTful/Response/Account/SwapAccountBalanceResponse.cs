using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class SwapAccountBalanceResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> data { get; set; }

        public class Data
        {
            [JsonProperty("state")]
            public string state { get; set; }

            [JsonProperty("equity")]
            public string equity { get; set; }

            [JsonProperty("isolated_equity")]
            public string isolatedEquity { get; set; }

            [JsonProperty("initial_margin")]
            public string initialMargin { get; set; }

            [JsonProperty("maintenance_margin")]
            public string maintenanceMargin { get; set; }

            [JsonProperty("maintenance_margin_rate")]
            public string maintenanceMarginRate { get; set; }

            [JsonProperty("profit_unreal")]
            public string profitUnreal { get; set; }

            [JsonProperty("available_margin")]
            public string availableMargin { get; set; }

            [JsonProperty("created_time")]
            public string createdTime { get; set; }

            [JsonProperty("updated_time")]
            public string updatedTime { get; set; }

            public List<Details> details { get; set; }
            public class Details
            {
                [JsonProperty("currency")]
                public string currency { get; set; }

                [JsonProperty("equity")]
                public string equity { get; set; }

                [JsonProperty("isolated_equity")]
                public string isolatedEquity { get; set; }

                [JsonProperty("available")]
                public string available { get; set; }

                [JsonProperty("profit_unreal")]
                public string profitUnreal { get; set; }

                [JsonProperty("isolated_available")]
                public string isolatedAvailable { get; set; }

                [JsonProperty("isolated_hold")]
                public string isolatedHold { get; set; }

                [JsonProperty("isolated_profit_unreal")]
                public string isolatedProfitUnreal { get; set; }

                [JsonProperty("initial_margin")]
                public string initialMargin { get; set; }

                [JsonProperty("maintenance_margin")]
                public string maintenanceMargin { get; set; }

                [JsonProperty("maintenance_margin_rate")]
                public string maintenanceMarginRate { get; set; }

                [JsonProperty("initial_margin_rate")]
                public string initialMarginRate { get; set; }

                [JsonProperty("created_time")]
                public string createdTime { get; set; }

                [JsonProperty("updated_time")]
                public string updatedTime { get; set; }
            }
        }
    }
}