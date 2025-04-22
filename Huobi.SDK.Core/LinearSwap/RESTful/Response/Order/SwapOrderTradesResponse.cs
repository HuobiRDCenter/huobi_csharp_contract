using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapOrderTradesResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("contract_code")]
        public string ContractCode { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("trade_id")]
        public string TradeId { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("position_side")]
        public string PositionSide { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("margin_mode")]
        public string MarginMode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("client_order_id")]
        public string ClientOrderId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("trade_price")]
        public string TradePrice { get; set; }

        [JsonProperty("trade_volume")]
        public string TradeVolume { get; set; }

        [JsonProperty("trade_turnover")]
        public string TradeTurnover { get; set; }

        [JsonProperty("created_time")]
        public long CreatedTime { get; set; }

        [JsonProperty("updated_time")]
        public long UpdatedTime { get; set; }

        [JsonProperty("order_source")]
        public string OrderSource { get; set; }

        [JsonProperty("fee_currency")]
        public string FeeCurrency { get; set; }

        [JsonProperty("trade_fee")]
        public string TradeFee { get; set; }

        [JsonProperty("deduction_currency")]
        public string DeductionCurrency { get; set; }

        [JsonProperty("deduction_amount")]
        public string DeductionAmount { get; set; }

        [JsonProperty("deduction_price")]
        public string DeductionPrice { get; set; }

        [JsonProperty("profit")]
        public string Profit { get; set; }

        [JsonProperty("contract_type")]
        public string ContractType { get; set; }
        }
    }
}