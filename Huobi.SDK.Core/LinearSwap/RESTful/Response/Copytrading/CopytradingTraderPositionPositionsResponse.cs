using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderPositionPositionsResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CopytradingTraderPositionPositionData Data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class CopytradingTraderPositionPosition
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

    [JsonProperty("open_time", NullValueHandling = NullValueHandling.Ignore)]
    public long OpenTime { get; set; }

    [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
    public string Volume { get; set; }

    [JsonProperty("close_time", NullValueHandling = NullValueHandling.Ignore)]
    public long CloseTime { get; set; }

    [JsonProperty("close_avg_price", NullValueHandling = NullValueHandling.Ignore)]
    public string CloseAvgPrice { get; set; }

    [JsonProperty("open_fee", NullValueHandling = NullValueHandling.Ignore)]
    public string OpenFee { get; set; }

    [JsonProperty("close_fee", NullValueHandling = NullValueHandling.Ignore)]
    public string CloseFee { get; set; }

    [JsonProperty("profit", NullValueHandling = NullValueHandling.Ignore)]
    public string Profit { get; set; }

    [JsonProperty("profit_rate", NullValueHandling = NullValueHandling.Ignore)]
    public string ProfitRate { get; set; }

    [JsonProperty("close_type", NullValueHandling = NullValueHandling.Ignore)]
    public int CloseType { get; set; }

    [JsonProperty("follow_takes", NullValueHandling = NullValueHandling.Ignore)]
    public string FollowTakes { get; set; }
}

public class CopytradingTraderPositionPositionData
{
    [JsonProperty("positions", NullValueHandling = NullValueHandling.Ignore)]
    public CopytradingTraderPositionPosition[] Positions { get; set; }

    [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
    public long QueryId { get; set; }
}
}