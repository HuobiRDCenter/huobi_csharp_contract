using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderUpdatedContractLeverRequest
    {
        [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractCode { get; set; }

        [JsonProperty("lever", NullValueHandling = NullValueHandling.Ignore)]
        public int Lever { get; set; }

        [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string MarginMode { get; set; }
    }
}