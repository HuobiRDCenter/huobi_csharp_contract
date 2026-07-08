using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class AssetModeResponse
    {
        public int code { get; set; }

        public string message { get; set; }

        public long ts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Data data { get; set; }

        public class Data
        {
            [JsonProperty("asset_mode")]
            public int assetMode { get; set; }
        }
    }
}
