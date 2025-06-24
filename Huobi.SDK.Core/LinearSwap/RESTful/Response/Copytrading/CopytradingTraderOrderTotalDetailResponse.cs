using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderOrderTotalDetailResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("total_follower_num", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalFollowerNum { get; set; }

        [JsonProperty("current_follower_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentFollowerNum { get; set; }

        [JsonProperty("total_pl", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPl { get; set; }

        [JsonProperty("win_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string WinRate { get; set; }

        [JsonProperty("last_24_hours_profit", NullValueHandling = NullValueHandling.Ignore)]
        public List<HourlyProfit> Last24HoursProfit { get; set; }

        [JsonProperty("last_90_days_profit", NullValueHandling = NullValueHandling.Ignore)]
        public List<DailyProfit> Last90DaysProfit { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class HourlyProfit
    {
        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public string Rate { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public string Ts { get; set; }
    }

    public class DailyProfit
    {
        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public string Rate { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public string Ts { get; set; }
    }
}