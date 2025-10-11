using System.Collections.Generic;
using Newtonsoft.Json;
namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class QueryEarnProjectListResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoResVo Data { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<SavingProjectDTO> Items { get; set; }
    }
    public class PageInfoResVo
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<SavingProjectDTO> Items { get; set; }
    }

    public class SavingProjectDTO
    {
        [JsonProperty("projectId")]
        public long ProjectId { get; set; }

        [JsonProperty("productId")]
        public long ProductId { get; set; }

        [JsonProperty("calculationType")]
        public int CalculationType { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("viewYearRate")]
        public decimal ViewYearRate { get; set; }

        [JsonProperty("finishAmount")]
        public decimal FinishAmount { get; set; }

        [JsonProperty("projectStatus")]
        public int ProjectStatus { get; set; }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startAmount")]
        public decimal StartAmount { get; set; }

        [JsonProperty("apyType")]
        public int ApyType { get; set; }

        [JsonProperty("tieredRates", NullValueHandling = NullValueHandling.Ignore)]
        public List<TieredRateVo> TieredRates { get; set; }

        [JsonProperty("marketPerkUpLimit", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketPerkUpLimit { get; set; }

        [JsonProperty("marketTimeApy", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MarketTimeApy { get; set; }

        [JsonProperty("marketPerkApy", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? MarketPerkApy { get; set; }
    }

    public class TieredRateVo
    {
        [JsonProperty("amountStart")]
        public decimal AmountStart { get; set; }

        [JsonProperty("amountEnd")]
        public decimal AmountEnd { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }
    }
}