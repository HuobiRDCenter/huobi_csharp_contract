using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Account
{
    public class ContractSubAuthListResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ContractSubAuthList Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        public class ContractSubAuthList
        {
            [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
            public List<ErrorsObject> Errors { get; set; }

            [JsonProperty("successes", NullValueHandling = NullValueHandling.Ignore)]
            public List<SuccessesObject> Successes { get; set; }
        }

        public class ErrorsObject
        {
            [JsonProperty("sub_uid", NullValueHandling = NullValueHandling.Ignore)]
            public string SubUid { get; set; }

            [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ErrCode { get; set; }

            [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
            public string ErrMsg { get; set; }
        }

        public class SuccessesObject
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public string QueryId { get; set; }
            
            [JsonProperty("sub_uid", NullValueHandling = NullValueHandling.Ignore)]
            public string SubUid { get; set; }

            [JsonProperty("sub_auth", NullValueHandling = NullValueHandling.Ignore)]
            public string SubAuth { get; set; }
        }
    }
}