using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderCloseAllPositionRequest
    {
        [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractCode { get; set; }

        [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string MarginMode { get; set; }

        [JsonProperty("position_side", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionSide { get; set; }
    }
}