using Newtonsoft.Json;
namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class EarnOrderDemandAddResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderSubscribeResDTO Data { get; set; }
    }
    public class OrderSubscribeResDTO
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("orderId")]
        public long OrderId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}