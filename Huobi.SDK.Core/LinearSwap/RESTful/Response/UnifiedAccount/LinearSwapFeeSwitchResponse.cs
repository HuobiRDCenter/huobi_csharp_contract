using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount
{
    public class LinearSwapFeeSwitchResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }
    }
}