using System;
using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapPositionHistoryResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("contract_code")]
            public string ContractCode { get; set; }

            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            [JsonProperty("cost_open")]
            public string CostOpen { get; set; }

            [JsonProperty("close_avg_price")]
            public string CloseAvgPrice { get; set; }

            [JsonProperty("volume")]
            public string Volume { get; set; }

            [JsonProperty("available")]
            public string Available { get; set; }

            [JsonProperty("lever_rate")]
            public string LeverRate { get; set; }

            [JsonProperty("profit")]
            public string Profit { get; set; }

            [JsonProperty("profit_ratio")]
            public string ProfitRatio { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("fee")]
            public string Fee { get; set; }

            [JsonProperty("funding_fee")]
            public string FundingFee { get; set; }

            [JsonProperty("margin_currency")]
            public string MarginCurrency { get; set; }

            [JsonProperty("last")]
            public decimal Last { get; set; }

            [JsonProperty("business_type")]
            public string BusinessType { get; set; }

            [JsonProperty("contract_type")]
            public string ContractType { get; set; }

            [JsonProperty("created_time")]
            public string CreatedTime { get; set; }

            [JsonProperty("updated_time")]
            public string UpdatedTime { get; set; }
        }
    }
}