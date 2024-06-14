using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Common
{
    public class TimestampResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
    }
}