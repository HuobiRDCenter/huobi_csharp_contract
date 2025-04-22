using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapPositionLeverResponse
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
            /// 仓位方向
            /// </summary>
            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            /// <summary>
            /// 杠杆等级
            /// </summary>
            [JsonProperty("lever_rate")]
            public string LeverRate { get; set; }

            /// <summary>
            /// 可用杠杆等级
            /// </summary>
            [JsonProperty("available_lever")]
            public string AvailableLever { get; set; }
        }
    }
}