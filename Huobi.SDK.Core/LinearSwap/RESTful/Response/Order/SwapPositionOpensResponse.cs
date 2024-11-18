using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapPositionOpensResponse
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
            /// 仓位方向，持仓方向（买卖模式下默认值both，开平仓模式下：long：平多 ，short：平空）
            /// </summary>
            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            /// <summary>
            /// 保证金模式（cross：全仓）
            /// </summary>
            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            /// <summary>
            /// 开仓均价
            /// </summary>
            [JsonProperty("cost_open")]
            public string CostOpen { get; set; }

            /// <summary>
            /// 持仓量（张）
            /// </summary>
            [JsonProperty("volume")]
            public string Volume { get; set; }

            /// <summary>
            /// 可平仓数量（张）
            /// </summary>
            [JsonProperty("available")]
            public string Available { get; set; }

            /// <summary>
            /// 杠杠倍数
            /// </summary>
            [JsonProperty("lever_rate")]
            public string LeverRate { get; set; }

            /// <summary>
            /// 自动减仓指示（(1、2、3、4、5)，1档风险最低，5档风险最高）
            /// </summary>
            [JsonProperty("adl_risk_percent")]
            public string AdlRiskPercent { get; set; }

            /// <summary>
            /// 预估强平价
            /// </summary>
            [JsonProperty("liquidation_price")]
            public string LiquidationPrice { get; set; }

            /// <summary>
            /// 初始保证金，仅适用于全仓
            /// </summary>
            [JsonProperty("initial_margin")]
            public string InitialMargin { get; set; }

            /// <summary>
            /// 维持保证金
            /// </summary>
            [JsonProperty("maintenance_margin")]
            public string MaintenanceMargin { get; set; }

            /// <summary>
            /// 逐仓保证金，仅适用于逐仓
            /// </summary>
            [JsonProperty("margin")]
            public string Margin { get; set; }

            /// <summary>
            /// 未实现盈亏
            /// </summary>
            [JsonProperty("profit_unreal")]
            public string ProfitUnreal { get; set; }

            /// <summary>
            /// 未实现收益率
            /// </summary>
            [JsonProperty("profit_rate")]
            public string ProfitRate { get; set; }

            /// <summary>
            /// 保证金率-对标调整信息
            /// </summary>
            [JsonProperty("margin_rate")]
            public string MarginRate { get; set; }

            /// <summary>
            /// 保证金币种（计价币种）
            /// </summary>
            [JsonProperty("margin_currency")]
            public string MarginCurrency { get; set; }

            /// <summary>
            /// 持仓模式（single_side：单向持仓；dual_side：双向持仓）
            /// </summary>
            [JsonProperty("position_mode")]
            public string PositionMode { get; set; }

            /// <summary>
            /// 最新价
            /// </summary>
            [JsonProperty("last")]
            public decimal Last { get; set; }

            /// <summary>
            /// 合约类型（swap（永续）、this_week（当周）、next_week（次周）、quarter（当季）、next_quarter（次季））
            /// </summary>
            [JsonProperty("contract_type")]
            public string ContractType { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [JsonProperty("created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [JsonProperty("updated_time")]
            public string UpdatedTime { get; set; }
        }
    }
}