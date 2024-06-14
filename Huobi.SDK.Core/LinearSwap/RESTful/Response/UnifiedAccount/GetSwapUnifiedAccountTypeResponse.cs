using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount
{
    public class GetSwapUnifiedAccountTypeResponse
    {
        public int code { get; set; }

        public string msg { get; set; }

        public long ts { get; set; }

        public SwapUnifiedAccountType data { get; set; }

        public class SwapUnifiedAccountType
        {
            [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
            public int accountType { get; set; }
        }
    }
}