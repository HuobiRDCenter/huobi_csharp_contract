using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeDeleteFollowerResult
    {
        [JsonProperty("followerUid", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerUid { get; set; }

        [JsonProperty("sCode", NullValueHandling = NullValueHandling.Ignore)]
        public string SCode { get; set; }

        [JsonProperty("sMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string SMsg { get; set; }
    }
}