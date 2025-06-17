using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderAddMarginResponse
    {
        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("data")]
        public AdjustMarginData Data { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }
    }
    
    public class AdjustMarginData
    {
        [JsonProperty("contract_code")]
        public string ContractCode { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("position_side")]
        public string PositionSide { get; set; }
    }
}