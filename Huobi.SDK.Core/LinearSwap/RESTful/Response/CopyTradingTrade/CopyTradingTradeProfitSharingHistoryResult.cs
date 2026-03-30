using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeProfitSharingHistoryResult
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("instType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstType { get; set; }

        [JsonProperty("followerName", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerName { get; set; }

        [JsonProperty("ccy", NullValueHandling = NullValueHandling.Ignore)]
        public string Ccy { get; set; }

        [JsonProperty("profitSharingAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfitSharingAmt { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public string Ts { get; set; }
    }
}