using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderProfitHistoryDetailsResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ProfitSharingData Data { get; set; }

        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public long QueryId { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class ProfitSharingData
    {
        [JsonProperty("profit_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProfitItem> ProfitItems { get; set; }
    }

    public class ProfitItem
    {
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [JsonProperty("profit_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfitCurrency { get; set; }

        [JsonProperty("profit_amont", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfitAmount { get; set; }

        [JsonProperty("profit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfitTime { get; set; }
    }
}