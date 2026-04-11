using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeFollowersResult
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("instType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstType { get; set; }

        [JsonProperty("followerAvatarLink", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerAvatarLink { get; set; }

        [JsonProperty("followerName", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerName { get; set; }

        [JsonProperty("followerUid", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerUid { get; set; }

        [JsonProperty("followTime", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowTime { get; set; }

        [JsonProperty("followerAssetAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerAssetAmt { get; set; }

        [JsonProperty("followerProfitSharingAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerProfitSharingAmt { get; set; }

        [JsonProperty("followerTradeAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerTradeAmt { get; set; }

        [JsonProperty("totalProfitSharingAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalProfitSharingAmt { get; set; }
    }
}