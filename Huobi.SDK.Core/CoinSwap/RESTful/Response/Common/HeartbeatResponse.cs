using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Response.Common
{
    public class HeartbeatResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public HeartbeatObject Data { get; set; }
        
        public class HeartbeatObject
        {
            [JsonProperty("heartbeat", NullValueHandling = NullValueHandling.Ignore)]
            public int Heartbeat { get; set; }

            [JsonProperty("swap_heartbeat", NullValueHandling = NullValueHandling.Ignore)]
            public int SwapHeartbeat { get; set; }

            [JsonProperty("estimated_recovery_time", NullValueHandling = NullValueHandling.Ignore)]
            public long EstimatedRecoveryTime { get; set; }

            [JsonProperty("swap_estimated_recovery_time", NullValueHandling = NullValueHandling.Ignore)]
            public long SwapEstimatedRecoveryTime { get; set; }

            [JsonProperty("linear_swap_heartbeat", NullValueHandling = NullValueHandling.Ignore)]
            public long LinearSwapHeartbeat { get; set; }

            [JsonProperty("linear_swap_estimated_recovery_time", NullValueHandling = NullValueHandling.Ignore)]
            public long LinearSwapEstimatedRecoveryTime { get; set; }
        }
    }
}