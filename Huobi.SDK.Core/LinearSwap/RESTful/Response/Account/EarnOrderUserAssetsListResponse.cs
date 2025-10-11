using System.Collections.Generic;
using Newtonsoft.Json;
namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class EarnOrderUserAssetsListResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoResVo1 Data { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserAssetsInfoCouponExpandResDto> Items { get; set; }
    }
    public class PageInfoResVo1
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserAssetsInfoCouponExpandResDto> Items { get; set; }
    }

    public class UserAssetsInfoCouponExpandResDto
    {
        [JsonProperty("projectId")]
        public long ProjectId { get; set; }

        [JsonProperty("orderId")]
        public long OrderId { get; set; }

        [JsonProperty("projectType")]
        public int ProjectType { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("yesterdayIncome")]
        public string YesterdayIncome { get; set; }

        [JsonProperty("totalIncomeAmount")]
        public string TotalIncomeAmount { get; set; }

        [JsonProperty("totalAmount")]
        public string TotalAmount { get; set; }

        [JsonProperty("miningYearRate")]
        public string MiningYearRate { get; set; }

        [JsonProperty("apyType")]
        public int ApyType { get; set; }
    }
}