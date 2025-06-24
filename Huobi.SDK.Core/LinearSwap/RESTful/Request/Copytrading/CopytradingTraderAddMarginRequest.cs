using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderAddMarginRequest
    {
        [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractCode { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("position_side", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionSide { get; set; }
    }
}