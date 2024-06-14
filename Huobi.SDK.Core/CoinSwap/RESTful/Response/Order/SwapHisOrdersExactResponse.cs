using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Response.Order
{
    public class SwapHisOrdersExactResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapHisOrdersExact> Data { get; set; }

        public class SwapHisOrdersExact
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public long QueryId { get; set; }

            [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
            public long OrderId { get; set; }

            [JsonProperty("order_id_str", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderIdStr { get; set; }

            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public int LeverRate { get; set; }

            [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
            public string Direction { get; set; }

            [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
            public string Offset { get; set; }

            [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Volume { get; set; }

            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Price { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public long CreateDate { get; set; }

            [JsonProperty("order_source", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderSource { get; set; }

            [JsonProperty("order_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderPriceType { get; set; }

            [JsonProperty("margin_frozen", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginFrozen { get; set; }

            [JsonProperty("profit", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Profit { get; set; }

            [JsonProperty("trade_volume", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradeVolume { get; set; }

            [JsonProperty("trade_turnover", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradeTurnover { get; set; }

            [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Fee { get; set; }

            [JsonProperty("trade_avg_price", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TradeAvgPrice { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public int Status { get; set; }

            [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
            public int OrderType { get; set; }

            [JsonProperty("fee_asset", NullValueHandling = NullValueHandling.Ignore)]
            public string FeeAsset { get; set; }

            [JsonProperty("liquidation_type", NullValueHandling = NullValueHandling.Ignore)]
            public string LiquidationType { get; set; }

            [JsonProperty("is_tpsl", NullValueHandling = NullValueHandling.Ignore)]
            public int IsTpsl { get; set; }

            [JsonProperty("real_profit", NullValueHandling = NullValueHandling.Ignore)]
            public decimal RealProfit { get; set; }

            [JsonProperty("canceled_source", NullValueHandling = NullValueHandling.Ignore)]
            public string CanceledSource { get; set; }
        }
    }
}