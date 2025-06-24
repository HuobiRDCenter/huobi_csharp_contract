using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading
{
    public class CopytradingTraderQueryContractResponse
    {
        [JsonProperty("tid", NullValueHandling = NullValueHandling.Ignore)]
        public string Tid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataItem> Data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
    }
    
    public class DataItem
    {
        [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractCode { get; set; }
    }
}