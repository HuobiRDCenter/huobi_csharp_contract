using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount
{
    public class UnifiedAccountInfoResponse
    {
        
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnifiedAccountInfo> Data { get; set; }
        
        public class UnifiedAccountInfo
        {
            [JsonProperty("margin_balance", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginBalance { get; set; }

            [JsonProperty("margin_static", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginStatic { get; set; }

            [JsonProperty("cross_profit_unreal", NullValueHandling = NullValueHandling.Ignore)]
            public decimal CrossProfitUnreal { get; set; }

            [JsonProperty("cross_margin_static", NullValueHandling = NullValueHandling.Ignore)]
            public decimal CrossMarginStatic { get; set; }

            [JsonProperty("margin_asset", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginAsset { get; set; }

            [JsonProperty("margin_frozen", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginFrozen { get; set; }

            [JsonProperty("withdraw_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal WithdrawAvailable { get; set; }

            [JsonProperty("cross_risk_rate", NullValueHandling = NullValueHandling.Ignore)]
            public decimal CrossRiskRate { get; set; }

            [JsonProperty("cross_swap", NullValueHandling = NullValueHandling.Ignore)]
            public List<CrossSwapObject> CrossSwap { get; set; }

            [JsonProperty("cross_futures", NullValueHandling = NullValueHandling.Ignore)]
            public List<CrossFuturesObject> CrossFutures { get; set; }

            [JsonProperty("isolated_swap", NullValueHandling = NullValueHandling.Ignore)]
            public List<IsolatedSwapObject> IsolatedSwap { get; set; }
        }

        public class CrossSwapObject
        {
            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginMode { get; set; }

            [JsonProperty("margin_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginAvailable { get; set; }

            [JsonProperty("cross_max_available", NullValueHandling = NullValueHandling.Ignore)]
            public int CrossMaxAvailable { get; set; }

            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public decimal LeverRate { get; set; }

            [JsonProperty("contract_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractType { get; set; }

            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public string BusinessType { get; set; }
        }

        public class CrossFuturesObject
        {
            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginMode { get; set; }

            [JsonProperty("margin_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginAvailable { get; set; }

            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public decimal LeverRate { get; set; }

            [JsonProperty("contract_type", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractType { get; set; }

            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public string BusinessType { get; set; }
        }

        public class IsolatedSwapObject
        {
            [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
            public string Symbol { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("margin_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string MarginMode { get; set; }

            [JsonProperty("margin_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal MarginAvailable { get; set; }

            [JsonProperty("withdraw_available", NullValueHandling = NullValueHandling.Ignore)]
            public decimal WithdrawAvailable { get; set; }

            [JsonProperty("lever_rate", NullValueHandling = NullValueHandling.Ignore)]
            public int LeverRate { get; set; }

            [JsonProperty("position_mode", NullValueHandling = NullValueHandling.Ignore)]
            public string PositionMode { get; set; }
        }
    }
}