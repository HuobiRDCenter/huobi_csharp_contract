using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade
{
    public class CopyTradingTradeStatisticsResult
    {
        [JsonProperty("instType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstType { get; set; }

        [JsonProperty("totalFollowerNum", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalFollowerNum { get; set; }

        [JsonProperty("curFollowerNum", NullValueHandling = NullValueHandling.Ignore)]
        public string CurFollowerNum { get; set; }

        [JsonProperty("totalPnl", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPnl { get; set; }

        [JsonProperty("followerTotalPnl", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowerTotalPnl { get; set; }

        [JsonProperty("winRate", NullValueHandling = NullValueHandling.Ignore)]
        public string WinRate { get; set; }

        [JsonProperty("winNum", NullValueHandling = NullValueHandling.Ignore)]
        public string WinNum { get; set; }

        [JsonProperty("lossNum", NullValueHandling = NullValueHandling.Ignore)]
        public string LossNum { get; set; }

        [JsonProperty("profitDetails90d", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProfitDetail> ProfitDetails90d { get; set; }

        public class ProfitDetail
        {
            [JsonProperty("pnlRate", NullValueHandling = NullValueHandling.Ignore)]
            public string PnlRate { get; set; }

            [JsonProperty("pnl", NullValueHandling = NullValueHandling.Ignore)]
            public string Pnl { get; set; }

            [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
            public string Ts { get; set; }
        }
    }
}