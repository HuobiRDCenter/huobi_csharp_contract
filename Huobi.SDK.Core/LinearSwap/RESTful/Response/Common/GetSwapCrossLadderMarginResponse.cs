using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Common
{
    public class GetSwapCrossLadderMarginResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapCrossLadderMargin> Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        public class SwapCrossLadderMargin
        {
            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginMode { get; set; }

            [JsonProperty("margin_account", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginAccount { get; set; }

            [JsonProperty("contract_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractType { get; set; }

            [JsonProperty("pair", NullValueHandling = NullValueHandling.Ignore)]
            public string Pair { get; set; }

            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public string BusinessType { get; set; }

            [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
            public List<ListObject> List { get; set; }
        }

        public class ListObject
        {
            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public int LeverRate { get; set; }

            [JsonProperty("ladders", NullValueHandling = NullValueHandling.Ignore)]
            public List<LaddersObject> Ladders { get; set; }
        }

        public class LaddersObject
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