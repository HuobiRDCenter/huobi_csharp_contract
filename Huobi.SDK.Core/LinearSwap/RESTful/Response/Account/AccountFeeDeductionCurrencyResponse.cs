using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class AccountFeeDeductionCurrencyResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataBean Data { get; set; }

        public class DataBean
        {
            [JsonProperty("fee_option", NullValueHandling = NullValueHandling.Ignore)]
            public int FeeOption { get; set; }

            [JsonProperty("deduction_currency", NullValueHandling = NullValueHandling.Ignore)]
            public string DeductionCurrency { get; set; }
        }
    }
}