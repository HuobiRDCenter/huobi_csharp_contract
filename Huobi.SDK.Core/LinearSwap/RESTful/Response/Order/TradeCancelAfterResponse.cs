using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class TradeCancelAfterResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataBean Data { get; set; }

        public class DataBean
        {
            [JsonProperty("current_time", NullValueHandling = NullValueHandling.Ignore)]
            public string CurrentTime { get; set; }

            [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
            public string TriggerTime { get; set; }
        }
    }
}