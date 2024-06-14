using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Response.Account
{
    public class SwapSubAuthListResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public SwapSubAuthList Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        public class SwapSubAuthList
        {

            [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
            public List<ErrorObject> Errors { get; set; }

            [JsonProperty("successes", NullValueHandling = NullValueHandling.Ignore)]
            public List<SuccessObject> Successes { get; set; }
        }

        public class ErrorObject
        {
            [JsonProperty("sub_uid", NullValueHandling = NullValueHandling.Ignore)]
            public string SubUid { get; set; }

            [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ErrCode { get; set; }

            [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
            public string ErrMsg { get; set; }
        }

        public class SuccessObject
        {
            [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
            public object QueryId { get; set; }
            
            [JsonProperty("sub_uid", NullValueHandling = NullValueHandling.Ignore)]
            public string SubUid { get; set; }

            [JsonProperty("sub_auth", NullValueHandling = NullValueHandling.Ignore)]
            public string SubAuth { get; set; }
        }
    }
}