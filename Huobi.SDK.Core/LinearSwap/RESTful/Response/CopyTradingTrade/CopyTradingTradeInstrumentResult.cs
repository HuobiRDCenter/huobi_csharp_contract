using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeInstrumentResult
    {
        [JsonProperty("instId", NullValueHandling = NullValueHandling.Ignore)]
        public string InstId { get; set; }

        [JsonProperty("instType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstType { get; set; }
    }
}