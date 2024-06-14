using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class SwapSubAuthListResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public SwapSubAuthList Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
    }
    
    public class SwapSubAuthList
    {
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Query_id { get; set; }

        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorsObject> Errors { get; set; }

        [JsonProperty("successes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SuccessesObject> Successes { get; set; }
    }

    public class ErrorsObject
    {
        [JsonProperty("sub_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sub_uid { get; set; }

        [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
        public string Err_code { get; set; }

        [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string err_msg { get; set; }
    }

    public class SuccessesObject
    {
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Query_id { get; set; }
        
        [JsonProperty("sub_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sub_uid { get; set; }

        [JsonProperty("sub_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string Sub_auth { get; set; }
    }
}