using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeConfigResult
    {
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool Enable { get; set; }

        [JsonProperty("profitSharingRatio", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfitSharingRatio { get; set; }

        [JsonProperty("maxFollowers", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxFollowers { get; set; }
    }
}