using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class GetTradeOrderResponse
    {
        public int code { get; set; }

        public long ts { get; set; }
        
        public string message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> data { get; set; }

        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("contract_code")]
            public string ContractCode { get; set; }

            [JsonProperty("side")]
            public string Side { get; set; }

            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("price_match")]
            public string PriceMatch { get; set; }

            [JsonProperty("order_id")]
            public string OrderId { get; set; }

            [JsonProperty("client_order_id")]
            public string ClientOrderId { get; set; }

            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            [JsonProperty("price")]
            public string Price { get; set; }

            [JsonProperty("volume")]
            public string Volume { get; set; }

            [JsonProperty("lever_rate")]
            public long LeverRate { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("order_source")]
            public string OrderSource { get; set; }

            [JsonProperty("reduce_only")]
            public bool ReduceOnly { get; set; }

            [JsonProperty("time_in_force")]
            public string TimeInForce { get; set; }

            [JsonProperty("tp_trigger_price")]
            public string TpTriggerPrice { get; set; }

            [JsonProperty("tp_order_price")]
            public string TpOrderPrice { get; set; }

            [JsonProperty("tp_type")]
            public string TpType { get; set; }

            [JsonProperty("tp_trigger_price_type")]
            public string TpTriggerPriceType { get; set; }

            [JsonProperty("sl_trigger_price")]
            public string SlTriggerPrice { get; set; }

            [JsonProperty("sl_order_price")]
            public string SlOrderPrice { get; set; }

            [JsonProperty("sl_type")]
            public string SlType { get; set; }

            [JsonProperty("sl_trigger_price_type")]
            public string SlTriggerPriceType { get; set; }

            [JsonProperty("trade_avg_price")]
            public string TradeAvgPrice { get; set; }

            [JsonProperty("trade_volume")]
            public string TradeVolume { get; set; }

            [JsonProperty("trade_turnover")]
            public string TradeTurnover { get; set; }

            [JsonProperty("fee_currency")]
            public string FeeCurrency { get; set; }

            [JsonProperty("fee")]
            public string Fee { get; set; }

            [JsonProperty("price_protect")]
            public bool PriceProtect { get; set; }

            [JsonProperty("profit")]
            public string Profit { get; set; }

            [JsonProperty("contract_type")]
            public string ContractType { get; set; }

            [JsonProperty("created_time")]
            public long CreatedTime { get; set; }

            [JsonProperty("updated_time")]
            public long UpdatedTime { get; set; }
        }
    }
}