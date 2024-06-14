using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Account
{
    public class ContractSubPositionInfoResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContractSubPositionInfo> Data { get; set; }
        
        public class ContractSubPositionInfo
        {
            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("contract_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractType { get; set; }

            [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Volume { get; set; }

            [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Available { get; set; }

            [JsonProperty("frozen", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Frozen { get; set; }

            [JsonProperty("cost_open", NullValueHandling = NullValueHandling.Ignore)]
            public decimal CostOpen { get; set; }

            [JsonProperty("cost_hold", NullValueHandling = NullValueHandling.Ignore)]
            public decimal CostHold { get; set; }

            [JsonProperty("profit_unreal", NullValueHandling = NullValueHandling.Ignore)]
            public decimal ProfitUnreal { get; set; }

            [JsonProperty("profit_rate", NullValueHandling = NullValueHandling.Ignore)]
            public decimal ProfitRate { get; set; }

            [JsonProperty("profit", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Profit { get; set; }

            [JsonProperty("position_margin", NullValueHandling = NullValueHandling.Ignore)]
            public decimal PositionMargin { get; set; }

            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public int LeverRate { get; set; }

            [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
            public string Direction { get; set; }

            [JsonProperty("last_price", NullValueHandling = NullValueHandling.Ignore)]
            public decimal LastPrice { get; set; }

            [JsonProperty("adl_risk_percent", NullValueHandling = NullValueHandling.Ignore)]
            public decimal AdlRiskPercent { get; set; }
            
            [JsonProperty("liq_px", NullValueHandling = NullValueHandling.Ignore)]
            public string liqPx { get; set; }

            [JsonProperty("new_risk_rate", NullValueHandling = NullValueHandling.Ignore)]
            public decimal NewRiskRate { get; set; }

            [JsonProperty("trade_partition", NullValueHandling = NullValueHandling.Ignore)]
            public string TradePartition { get; set; }
        }
    }
}