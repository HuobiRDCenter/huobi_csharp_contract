using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class UniversalTransferRecordsResponse
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
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public long Id { get; set; }

            [JsonProperty("transfer_id", NullValueHandling = NullValueHandling.Ignore)]
            public long TransferId { get; set; }

            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
            public string Amount { get; set; }

            [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
            public string Currency { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("from_account_type", NullValueHandling = NullValueHandling.Ignore)]
            public string FromAccountType { get; set; }

            [JsonProperty("to_account_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ToAccountType { get; set; }

            [JsonProperty("from_asset_type", NullValueHandling = NullValueHandling.Ignore)]
            public string FromAssetType { get; set; }

            [JsonProperty("to_asset_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ToAssetType { get; set; }

            [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
            public long Ts { get; set; }
        }
    }
}