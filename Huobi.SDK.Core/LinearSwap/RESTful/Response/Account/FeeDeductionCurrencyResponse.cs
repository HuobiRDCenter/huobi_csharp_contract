using Newtonsoft.Json;
namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class FeeDeductionCurrencyResponse
    {
        [JsonProperty("fee_option", NullValueHandling = NullValueHandling.Ignore)]
        public int FeeOption { get; set; }

        [JsonProperty("deduction_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string DeductionCurrency { get; set; }
    }
}