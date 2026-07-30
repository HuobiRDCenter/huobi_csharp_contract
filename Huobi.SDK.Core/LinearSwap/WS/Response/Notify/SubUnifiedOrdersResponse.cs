using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.WS.Response.Notify
{
    public class SubUnifiedOrdersResponse
    {
        public string op { get; set; }

        public string topic { get; set; }

        public long ts { get; set; }

        public string uid { get; set; }

        public Data data { get; set; }

        public class Data
        {
            [JsonProperty("contract_code")]
            public string contractCode { get; set; }

            [JsonProperty("contract_type")]
            public string contractType { get; set; }

            public string side { get; set; }

            [JsonProperty("position_side")]
            public string positionSide { get; set; }

            public string type { get; set; }

            [JsonProperty("price_match")]
            public string priceMatch { get; set; }

            [JsonProperty("order_id")]
            public string orderId { get; set; }

            [JsonProperty("client_order_id")]
            public string clientOrderId { get; set; }

            [JsonProperty("margin_mode")]
            public string marginMode { get; set; }

            public string price { get; set; }

            public string volume { get; set; }

            [JsonProperty("lever_rate")]
            public long leverRate { get; set; }

            public string state { get; set; }

            [JsonProperty("trade_turnover")]
            public string tradeTurnover { get; set; }

            [JsonProperty("trade_avg_price")]
            public string tradeAvgPrice { get; set; }

            [JsonProperty("trade_volume")]
            public string tradeVolume { get; set; }

            [JsonProperty("cancel_volume", NullValueHandling = NullValueHandling.Ignore)]
            public string cancelVolume { get; set; }

            [JsonProperty("order_source")]
            public string orderSource { get; set; }

            [JsonProperty("cancel_reason")]
            public string cancelReason { get; set; }

            [JsonProperty("reduce_only")]
            public bool reduceOnly { get; set; }

            [JsonProperty("time_in_force")]
            public string timeInForce { get; set; }

            [JsonProperty("fee_currency")]
            public string feeCurrency { get; set; }

            public string fee { get; set; }

            [JsonProperty("tp_trigger_price")]
            public string tpTriggerPrice { get; set; }

            [JsonProperty("tp_order_price")]
            public string tpOrderPrice { get; set; }

            [JsonProperty("tp_type")]
            public string tpType { get; set; }

            [JsonProperty("tp_trigger_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string tpTriggerPriceType { get; set; }

            [JsonProperty("sl_trigger_price")]
            public string slTriggerPrice { get; set; }

            [JsonProperty("sl_order_price")]
            public string slOrderPrice { get; set; }

            [JsonProperty("sl_type")]
            public string slType { get; set; }

            [JsonProperty("sl_trigger_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string slTriggerPriceType { get; set; }

            [JsonProperty("price_protect", NullValueHandling = NullValueHandling.Ignore)]
            public bool? priceProtect { get; set; }

            public string profit { get; set; }

            [JsonProperty("created_time")]
            public string createdTime { get; set; }

            [JsonProperty("updated_time")]
            public string updatedTime { get; set; }

            [JsonProperty("self_match_prevent")]
            public string selfMatchPrevent { get; set; }

            [JsonProperty("amend_origin_volume")]
            public string amendOriginVolume { get; set; }

            [JsonProperty("amend_source")]
            public string amendSource { get; set; }

            [JsonProperty("amend_result")]
            public string amendResult { get; set; }
        }
    }
}
