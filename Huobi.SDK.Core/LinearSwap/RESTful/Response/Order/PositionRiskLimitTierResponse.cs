using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class PositionRiskLimitTierResponse
    {
        public int code { get; set; }

        public string message { get; set; }

        public long ts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> data { get; set; }

        public class Data
        {
            [JsonProperty("contract_code")]
            public string contractCode { get; set; }

            [JsonProperty("contract_type")]
            public string contractType { get; set; }

            [JsonProperty("margin_mode")]
            public string marginMode { get; set; }

            [JsonProperty("position_side")]
            public string positionSide { get; set; }

            [JsonProperty("max_lever")]
            public string maxLever { get; set; }

            [JsonProperty("maintenance_margin_rate")]
            public string maintenanceMarginRate { get; set; }

            [JsonProperty("max_volume")]
            public string maxVolume { get; set; }

            [JsonProperty("min_volume")]
            public string minVolume { get; set; }

            [JsonProperty("volume_unit")]
            public string volumeUnit { get; set; }
        }
    }
}
