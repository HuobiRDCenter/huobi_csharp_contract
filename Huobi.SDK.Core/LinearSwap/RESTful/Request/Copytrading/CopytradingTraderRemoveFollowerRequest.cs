using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderRemoveFollowerRequest
    {
        [JsonProperty("follower_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerUid { get; set; }
    }
}