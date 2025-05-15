using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapOrderHistoryResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            /// <summary>
            /// 查询id
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; }

            /// <summary>
            /// 合约代码
            /// </summary>
            [JsonProperty("contract_code")]
            public string ContractCode { get; set; }

            /// <summary>
            /// 买卖方向
            /// </summary>
            [JsonProperty("side")]
            public string Side { get; set; }

            /// <summary>
            /// 开平方向
            /// </summary>
            [JsonProperty("position_side")]
            public string PositionSide { get; set; }

            /// <summary>
            /// 订单类型；枚举
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }

            /// <summary>
            /// 最优档位，和price互斥
            /// </summary>
            [JsonProperty("price_match")]
            public string PriceMatch { get; set; }

            /// <summary>
            /// 订单id
            /// </summary>
            [JsonProperty("order_id")]
            public string OrderId { get; set; }

            /// <summary>
            /// 用户自定义订单ID
            /// </summary>
            [JsonProperty("client_order_id")]
            public string ClientOrderId { get; set; }

            /// <summary>
            /// 保证金模式
            /// </summary>
            [JsonProperty("margin_mode")]
            public string MarginMode { get; set; }

            /// <summary>
            /// 委托价格
            /// </summary>
            [JsonProperty("price")]
            public string Price { get; set; }
            
            [JsonProperty("cancel_reason")]
            public string CancelReason { get; set; }

            /// <summary>
            /// 委托数量
            /// </summary>
            [JsonProperty("volume")]
            public string Volume { get; set; }

            /// <summary>
            /// 杠杆等级
            /// </summary>
            [JsonProperty("lever_rate")]
            public string LeverRate { get; set; }

            /// <summary>
            /// 订单状态
            /// </summary>
            [JsonProperty("state")]
            public string State { get; set; }

            /// <summary>
            /// 撤单原因
            /// </summary>
            [JsonProperty("canceled_source")]
            public string CanceledSource { get; set; }

            /// <summary>
            /// 订单来源
            /// </summary>
            [JsonProperty("order_source")]
            public string OrderSource { get; set; }

            /// <summary>
            /// 只减仓
            /// </summary>
            [JsonProperty("reduce_only")]
            public bool ReduceOnly { get; set; }

            /// <summary>
            /// 枚举fok, ioc, gtc，非必填，默认是gtc
            /// </summary>
            [JsonProperty("time_in_force")]
            public string TimeInForce { get; set; }

            /// <summary>
            /// 止盈触发价格--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("tp_trigger_price")]
            public string TpTriggerPrice { get; set; }

            /// <summary>
            /// 止盈委托价格（最优N档委托类型时无需填写价格）--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("tp_order_price")]
            public string TpOrderPrice { get; set; }

            /// <summary>
            /// 止盈委托类型,不填默认为market: 市价，maket: 限价：limit ，最优5档： optimal_5，最优10档：optimal_10，最优20档：optimal_20--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("tp_type")]
            public string TpType { get; set; }

            /// <summary>
            /// 止盈价格触发类型，默认是最新价--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("tp_trigger_price_type")]
            public int? TpTriggerPriceType { get; set; }

            /// <summary>
            /// 止损触发价格--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("sl_trigger_price")]
            public string SlTriggerPrice { get; set; }

            /// <summary>
            /// 止损委托价格（最优N档委托类型时无需填写价格）--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("sl_order_price")]
            public string SlOrderPrice { get; set; }

            /// <summary>
            /// 止损委托类型,不填默认为 市价，maket: 限价：limit ，最优5档： optimal_5，最优10档：optimal_10，最优20档：optimal_20--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("sl_type")]
            public string SlType { get; set; }

            /// <summary>
            /// 止损价格触发类型，默认是最新价--字段保留，暂时不对外
            /// </summary>
            [JsonProperty("sl_trigger_price_type")]
            public int? SlTriggerPriceType { get; set; }

            /// <summary>
            /// 成交均价
            /// </summary>
            [JsonProperty("trade_avg_price")]
            public string TradeAvgPrice { get; set; }

            /// <summary>
            /// 成交数量
            /// </summary>
            [JsonProperty("trade_volume")]
            public string TradeVolume { get; set; }

            /// <summary>
            /// 成交总金额
            /// </summary>
            [JsonProperty("trade_turnover")]
            public string TradeTurnover { get; set; }

            /// <summary>
            /// 手续费币种名称
            /// </summary>
            [JsonProperty("fee_currency")]
            public string FeeCurrency { get; set; }

            /// <summary>
            /// 手续费数量
            /// </summary>
            [JsonProperty("fee")]
            public string Fee { get; set; }

            /// <summary>
            /// 手续费抵扣币种名称
            /// </summary>
            [JsonProperty("deduction_currency")]
            public string DeductionCurrency { get; set; }

            /// <summary>
            /// 累计手续费抵扣数量
            /// </summary>
            [JsonProperty("deduction_amount")]
            public string DeductionAmount { get; set; }

            /// <summary>
            /// 平仓盈亏（使用持仓均价计算，不包含仓位跨结算的已实现盈亏。）
            /// </summary>
            [JsonProperty("profit")]
            public string Profit { get; set; }

            /// <summary>
            /// 合约类型
            /// </summary>
            [JsonProperty("contract_type")]
            public string ContractType { get; set; }

            /// <summary>
            /// 订单创建时间, UTC时间戳(MS)
            /// </summary>
            [JsonProperty("created_time")]
            public string CreatedTime { get; set; }

            /// <summary>
            /// 订单更新时间, UTC时间戳(MS)
            /// </summary>
            [JsonProperty("updated_time")]
            public string UpdatedTime { get; set; }
        }
    }
}