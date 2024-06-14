using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapCrossMatchResultsExactResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapCrossMatchResultsExact> Data { get; set; }
        
        public class SwapCrossMatchResultsExact
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public long QueryId { get; set; }

            [JsonProperty("match_id", NullValueHandling = NullValueHandling.Ignore)]
            public long MatchId { get; set; }

            [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
            public long OrderId { get; set; }

            [JsonProperty("order_id_str", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderIdStr { get; set; }

            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginMode { get; set; }

            [JsonProperty("margin_account", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginAccount { get; set; }

            [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
            public string Direction { get; set; }

            [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
            public string Offset { get; set; }

            [JsonProperty("trade_volume", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradeVolume { get; set; }

            [JsonProperty("trade_price", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradePrice { get; set; }

            [JsonProperty("trade_turnover", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradeTurnover { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public long CreateDate { get; set; }

            [JsonProperty("offset_profitloss", NullValueHandling = NullValueHandling.Ignore)]
            public decimal OffsetProfitloss { get; set; }

            [JsonProperty("real_profit", NullValueHandling = NullValueHandling.Ignore)]
            public decimal RealProfit { get; set; }

            [JsonProperty("trade_fee", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradeFee { get; set; }

            [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
            public string Role { get; set; }

            [JsonProperty("fee_asset", NullValueHandling = NullValueHandling.Ignore)]
            public string FeeAsset { get; set; }

            [JsonProperty("ht_price", NullValueHandling = NullValueHandling.Ignore)]
            public string HtPrice { get; set; }

            [JsonProperty("order_source", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderSource { get; set; }

            [JsonProperty("contract_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractType { get; set; }

            [JsonProperty("pair", NullValueHandling = NullValueHandling.Ignore)]
            public string Pair { get; set; }

            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public string BusinessType { get; set; }

            [JsonProperty("reduce_only", NullValueHandling = NullValueHandling.Ignore)]
            public int ReduceOnly { get; set; }
        }
    }
}