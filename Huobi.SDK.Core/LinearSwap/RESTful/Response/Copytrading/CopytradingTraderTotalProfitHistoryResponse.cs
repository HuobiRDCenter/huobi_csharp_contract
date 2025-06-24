using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderTotalProfitHistoryResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CopytradingTraderTotalProfitHistor Data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class CopytradingTraderTotalProfitHistor
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [JsonProperty("profit_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfitCurrency { get; set; }

        [JsonProperty("total_profit_amont", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalProfitAmount { get; set; }
    }
}