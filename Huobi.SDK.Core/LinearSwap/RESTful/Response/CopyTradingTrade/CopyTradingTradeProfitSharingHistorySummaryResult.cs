using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeProfitSharingHistorySummaryResult
    {
        [JsonProperty("instType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstType { get; set; }

        [JsonProperty("ccy", NullValueHandling = NullValueHandling.Ignore)]
        public string Ccy { get; set; }

        [JsonProperty("totalAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmt { get; set; }
    }
}