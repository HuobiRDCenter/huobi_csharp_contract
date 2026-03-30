using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Algo
{
    public class CancelAlgoOrdersResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataBean> Data { get; set; }

        public class DataBean
        {
            [JsonProperty("algo_id", NullValueHandling = NullValueHandling.Ignore)]
            public string AlgoId { get; set; }

            [JsonProperty("algo_client_order_id", NullValueHandling = NullValueHandling.Ignore)]
            public string AlgoClientOrderId { get; set; }

            [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
            public bool Success { get; set; }

            [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
            public string ErrorMsg { get; set; }

            [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
            public int ErrorCode { get; set; }
        }
    }
}