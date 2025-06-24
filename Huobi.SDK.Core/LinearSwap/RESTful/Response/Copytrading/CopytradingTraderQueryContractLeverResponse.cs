using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderQueryContractLeverResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public LeverageData Data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class LeverageData
    {
        [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractCode { get; set; }

        [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string MarginMode { get; set; }

        [JsonProperty("lever_rate_range", NullValueHandling = NullValueHandling.Ignore)]
        public int LeverRateRange { get; set; }

        [JsonProperty("current_lever_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int CurrentLeverRate { get; set; }
    }
}