using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderCurrentPositionsResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseData Data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class CopytradingTraderCurrentPosition
    {
        [JsonProperty("sub_position_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubPositionId { get; set; }

        [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string MarginMode { get; set; }

        [JsonProperty("position_side", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionSide { get; set; }

        [JsonProperty("lever", NullValueHandling = NullValueHandling.Ignore)]
        public string Lever { get; set; }

        [JsonProperty("open_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenOrderId { get; set; }

        [JsonProperty("open_avg_price", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenAvgPrice { get; set; }

        [JsonProperty("open_fee", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenFee { get; set; }

        [JsonProperty("open_time", NullValueHandling = NullValueHandling.Ignore)]
        public long OpenTime { get; set; }

        [JsonProperty("position_margin", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionMargin { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public string Volume { get; set; }

        [JsonProperty("liquidation_price", NullValueHandling = NullValueHandling.Ignore)]
        public string LiquidationPrice { get; set; }

        [JsonProperty("tp_trigger_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TpTriggerPrice { get; set; }

        [JsonProperty("sl_trigger_price", NullValueHandling = NullValueHandling.Ignore)]
        public string SlTriggerPrice { get; set; }
    }

    public class ResponseData
    {
        [JsonProperty("positions", NullValueHandling = NullValueHandling.Ignore)]
        public CopytradingTraderCurrentPosition[] Positions { get; set; }

        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public long QueryId { get; set; }
    }
}