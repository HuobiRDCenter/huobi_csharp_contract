using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderPositionListResponse
    {
        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }
    }
    
    public class Data
    {
        [JsonProperty("positions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Position> Positions { get; set; }
    }

    public class Position
    {
        [JsonProperty("margin_mode")]
        public string MarginMode { get; set; }

        [JsonProperty("position_side")]
        public string PositionSide { get; set; }

        [JsonProperty("lever")]
        public string Lever { get; set; }

        [JsonProperty("open_avg_price")]
        public string OpenAvgPrice { get; set; }

        [JsonProperty("position_margin")]
        public string PositionMargin { get; set; }

        [JsonProperty("margin_rate")]
        public string MarginRate { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("liquidation_price")]
        public string LiquidationPrice { get; set; }

        [JsonProperty("unreal_profit")]
        public string UnrealProfit { get; set; }

        [JsonProperty("profit")]
        public string Profit { get; set; }

        [JsonProperty("profit_rate")]
        public string ProfitRate { get; set; }

        [JsonProperty("contract_code")]
        public string ContractCode { get; set; }
    }
}