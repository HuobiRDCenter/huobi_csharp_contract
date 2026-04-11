using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Huobi.SDK.Core.Futures.WS.Response.Notify
{
    /// <summary>
    /// 订单成交推送响应
    /// </summary>
    public class SubMatchOrdersResponse
    {
        public string op { get; set; }

        public string topic { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string cid { get; set; }

        public long ts { get; set; }

        public string uid { get; set; }

        [JsonProperty("data")]
        public List<OrderData> data { get; set; }

        public class OrderData
        {
            [JsonProperty("contract_code")]
            public string contractCode { get; set; }

            public string side { get; set; }

            [JsonProperty("position_side")]
            public string positionSide { get; set; }

            public string type { get; set; }

            [JsonProperty("price_match")]
            public object priceMatch { get; set; }

            [JsonProperty("order_id")]
            public string orderId { get; set; }

            [JsonProperty("client_order_id")]
            public string clientOrderId { get; set; }

            [JsonProperty("trade_id")]
            public string tradeId { get; set; }

            [JsonProperty("margin_mode")]
            public string marginMode { get; set; }

            public string price { get; set; }

            public string volume { get; set; }

            [JsonProperty("lever_rate")]
            public string leverRate { get; set; }

            public string state { get; set; }

            [JsonProperty("order_source")]
            public string orderSource { get; set; }

            [JsonProperty("time_in_force")]
            public string timeInForce { get; set; }

            [JsonProperty("reduce_only")]
            public bool reduceOnly { get; set; }

            [JsonProperty("trade_price")]
            public string tradePrice { get; set; }

            [JsonProperty("trade_volume")]
            public string tradeVolume { get; set; }

            [JsonProperty("total_trade_volume")]
            public string totalTradeVolume { get; set; }

            [JsonProperty("cancel_reason")]
            public string cancelReason { get; set; }

            [JsonProperty("created_time")]
            public string createdTime { get; set; }

            [JsonProperty("match_time")]
            public string matchTime { get; set; }

            [JsonProperty("self_match_prevent")]
            public string selfMatchPrevent { get; set; }

            public string id { get; set; }

            public string role { get; set; }

            [JsonProperty("trade_turnover")]
            public string tradeTurnover { get; set; }

            [JsonProperty("contract_type")]
            public string contractType { get; set; }
        }
    }
}