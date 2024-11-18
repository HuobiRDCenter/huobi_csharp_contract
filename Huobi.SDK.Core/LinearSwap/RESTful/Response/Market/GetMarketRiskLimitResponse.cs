using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class GetMarketRiskLimitResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            /// <summary>
            /// 合约代码
            /// </summary>
            [JsonProperty("contract_code")]
            public string ContractCode { get; set; }

            /// <summary>
            /// 合约类型
            /// </summary>
            [JsonProperty("contract_type")]
            public string ContractType { get; set; }

            /// <summary>
            /// 保证金模式
            /// </summary>
            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            /// <summary>
            /// 层级
            /// </summary>
            [JsonProperty("tier")]
            public string Tier { get; set; }

            /// <summary>
            /// 该层最大杠杆等级
            /// </summary>
            [JsonProperty("max_lever")]
            public string MaxLever { get; set; }

            /// <summary>
            /// 该层维持保证率
            /// </summary>
            [JsonProperty("maintenance_margin_rate")]
            public string MaintenanceMarginRate { get; set; }

            /// <summary>
            /// 该层最高持有张数
            /// </summary>
            [JsonProperty("max_volume")]
            public string MaxVolume { get; set; }

            /// <summary>
            /// 该层最低持有张数
            /// </summary>
            [JsonProperty("min_volume")]
            public string MinVolume { get; set; }
        }
    }
}