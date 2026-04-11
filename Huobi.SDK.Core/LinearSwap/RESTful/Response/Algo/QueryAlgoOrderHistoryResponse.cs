using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Algo
{
    public class QueryAlgoOrderHistoryResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<HistoryAlgoOrderData> Data { get; set; }

        public class HistoryAlgoOrderData
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public string Id { get; set; }

            [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
            public string Volume { get; set; }

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public string Type { get; set; }

            [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
            public string State { get; set; }

            [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
            public string Side { get; set; }

            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public string Price { get; set; }

            [JsonProperty("algo_id", NullValueHandling = NullValueHandling.Ignore)]
            public string AlgoId { get; set; }

            [JsonProperty("algo_client_order_id", NullValueHandling = NullValueHandling.Ignore)]
            public string AlgoClientOrderId { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("position_side", NullValueHandling = NullValueHandling.Ignore)]
            public string PositionSide { get; set; }

            [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginMode { get; set; }

            [JsonProperty("relation_order_id", NullValueHandling = NullValueHandling.Ignore)]
            public string RelationOrderId { get; set; }

            [JsonProperty("actual_volume", NullValueHandling = NullValueHandling.Ignore)]
            public string ActualVolume { get; set; }

            [JsonProperty("actual_price", NullValueHandling = NullValueHandling.Ignore)]
            public string ActualPrice { get; set; }

            [JsonProperty("actual_time", NullValueHandling = NullValueHandling.Ignore)]
            public string ActualTime { get; set; }

            [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedTime { get; set; }

            [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedTime { get; set; }

            [JsonProperty("order_source", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderSource { get; set; }

            [JsonProperty("price_match", NullValueHandling = NullValueHandling.Ignore)]
            public string PriceMatch { get; set; }

            [JsonProperty("trigger_price", NullValueHandling = NullValueHandling.Ignore)]
            public string TriggerPrice { get; set; }

            [JsonProperty("trigger_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string TriggerPriceType { get; set; }

            [JsonProperty("tp_trigger_price", NullValueHandling = NullValueHandling.Ignore)]
            public string TpTriggerPrice { get; set; }

            [JsonProperty("tp_order_price", NullValueHandling = NullValueHandling.Ignore)]
            public string TpOrderPrice { get; set; }

            [JsonProperty("tp_type", NullValueHandling = NullValueHandling.Ignore)]
            public string TpType { get; set; }

            [JsonProperty("tp_trigger_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string TpTriggerPriceType { get; set; }

            [JsonProperty("sl_trigger_price", NullValueHandling = NullValueHandling.Ignore)]
            public string SlTriggerPrice { get; set; }

            [JsonProperty("sl_order_price", NullValueHandling = NullValueHandling.Ignore)]
            public string SlOrderPrice { get; set; }

            [JsonProperty("sl_type", NullValueHandling = NullValueHandling.Ignore)]
            public string SlType { get; set; }

            [JsonProperty("sl_trigger_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string SlTriggerPriceType { get; set; }

            [JsonProperty("active_price", NullValueHandling = NullValueHandling.Ignore)]
            public string ActivePrice { get; set; }

            [JsonProperty("order_price_type", NullValueHandling = NullValueHandling.Ignore)]
            public string OrderPriceType { get; set; }

            [JsonProperty("callback_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string CallbackRate { get; set; }

            [JsonProperty("reduce_only", NullValueHandling = NullValueHandling.Ignore)]
            public bool? ReduceOnly { get; set; }
        }
    }
}