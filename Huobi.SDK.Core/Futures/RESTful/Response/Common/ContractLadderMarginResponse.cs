using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Common
{
    public class ContractLadderMarginResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContractLadderMargin> Data { get; set; }
        
        public class ContractLadderMargin
        {
            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
            public List<ListObject> List { get; set; }
        }

        public class ListObject
        {
            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public int LeverRate { get; set; }

            [JsonProperty("ladders", NullValueHandling = NullValueHandling.Ignore)]
            public List<LadderObject> Ladders { get; set; }
        }

        public class LadderObject
        {
            [JsonProperty("min_margin_balance", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MinMarginBalance { get; set; }

            [JsonProperty("max_margin_balance", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MaxMarginBalance { get; set; }

            [JsonProperty("min_margin_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MinMarginAvailable { get; set; }

            [JsonProperty("max_margin_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MaxMarginAvailable { get; set; }
        }
    }
}