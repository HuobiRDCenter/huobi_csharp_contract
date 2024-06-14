using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class SwapFinancialRecordResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapFinancialRecord> Data { get; set; }
        
        public class SwapFinancialRecord
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public long QueryId { get; set; }

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public long Id { get; set; }

            [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
            public long Ts { get; set; }

            [JsonProperty("asset", NullValueHandling = NullValueHandling.Ignore)]
            public string Asset { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("margin_account", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginAccount { get; set; }

            [JsonProperty("face_margin_account", NullValueHandling = NullValueHandling.Ignore)]
            public string FaceMarginAccount { get; set; }

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public int Type { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Amount { get; set; }
        }
    }
}