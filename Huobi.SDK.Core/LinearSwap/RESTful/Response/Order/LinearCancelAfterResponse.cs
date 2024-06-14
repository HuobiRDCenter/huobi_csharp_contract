using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class LinearCancelAfterResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public LinearCancelAfter Data { get; set; }
        
        public class LinearCancelAfter
        {
            [JsonProperty("current_time", NullValueHandling = NullValueHandling.Ignore)]
            public long CurrentTime { get; set; }

            [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
            public long TriggerTime { get; set; }
        }
    }
}