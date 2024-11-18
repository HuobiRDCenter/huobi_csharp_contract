using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class PositionLeverResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            /// <summary>
            /// 合约代码，对应原参数中的contract_code
            /// </summary>
            [JsonProperty("contract_code")]
            public string ContractCode { get; set; }

            /// <summary>
            /// 保证金模式，对应原参数中的margin_mode
            /// </summary>
            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            /// <summary>
            /// 仓位方向，对应原参数中的position_side
            /// </summary>
            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            /// <summary>
            /// 杠杆等级，对应原参数中的lever_rate
            /// </summary>
            [JsonProperty("lever_rate")]
            public string LeverRate { get; set; }
        }
    }
}