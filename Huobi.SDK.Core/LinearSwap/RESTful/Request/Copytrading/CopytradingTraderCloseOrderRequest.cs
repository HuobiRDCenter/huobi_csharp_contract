using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderCloseOrderRequest
    {
        [JsonProperty("sub_position_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubPositionId { get; set; }
    }
}