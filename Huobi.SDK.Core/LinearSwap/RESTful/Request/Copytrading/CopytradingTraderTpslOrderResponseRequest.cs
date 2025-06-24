using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderTpslOrderResponseRequest
    {
        [JsonProperty("sub_position_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubPositionId { get; set; }

        [JsonProperty("tp_trigger_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TpTriggerPrice { get; set; }

        [JsonProperty("sl_trigger_price", NullValueHandling = NullValueHandling.Ignore)]
        public string SlTriggerPrice { get; set; }
    }
}