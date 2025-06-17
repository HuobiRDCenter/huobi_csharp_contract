using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderQueryFollowersResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CopytradingTraderQueryFollowers Data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    
    public class CopytradingTraderQueryFollowers
    {
        [JsonProperty("follower", NullValueHandling = NullValueHandling.Ignore)]
        public List<Follower> Followers { get; set; }

        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }
    }

    public class Follower
    {
        [JsonProperty("follower_head_pic", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerHeadPic { get; set; }

        [JsonProperty("follower_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerName { get; set; }

        [JsonProperty("follower_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerUid { get; set; }

        [JsonProperty("follower_time", NullValueHandling = NullValueHandling.Ignore)]
        public long FollowerTime { get; set; }

        [JsonProperty("follower_profit_amont", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerProfitAmont { get; set; }

        [JsonProperty("follower_trade_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerTradeAmount { get; set; }
    }
}