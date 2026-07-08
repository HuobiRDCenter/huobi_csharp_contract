using Newtonsoft.Json;
namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class FeeDeductionCurrencyResponse
    {
        public int code { get; set; }

        public string message { get; set; }

        public long ts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Data data { get; set; }

        public class Data
        {
            [JsonProperty("fee_option")]
            public int FeeOption { get; set; }

            [JsonProperty("deduction_currency")]
            public string DeductionCurrency { get; set; }
        }
    }
}