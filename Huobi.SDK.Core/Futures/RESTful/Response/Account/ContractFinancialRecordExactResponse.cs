using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Account
{
    public class ContractFinancialRecordExactResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContractFinancialRecordExact> Data { get; set; }
        
        public class ContractFinancialRecordExact
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public long QueryId { get; set; }

            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public long Id { get; set; }

            [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
            public long Ts { get; set; }

            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
            public int Type { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public decimal Amount { get; set; }
        }
    }
}