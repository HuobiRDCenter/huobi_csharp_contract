using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Response.Common
{
    public class SwapQueryElementsResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapQueryElements> Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        public class SwapQueryElements
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_index_code", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentIndexCode { get; set; }

            [JsonProperty("real_time_settlement", NullValueHandling = NullValueHandling.Ignore)]
            public int RealTimeSettlement { get; set; }

            [JsonProperty("transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public dynamic TransferProfitRatio { get; set; }

            [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
            public int MinLevel { get; set; }

            [JsonProperty("max_level", NullValueHandling = NullValueHandling.Ignore)]
            public int MaxLevel { get; set; }

            [JsonProperty("open_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int OpenOrderLimit { get; set; }

            [JsonProperty("offset_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int OffsetOrderLimit { get; set; }

            [JsonProperty("long_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int LongPositionLimit { get; set; }

            [JsonProperty("short_position_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int ShortPositionLimit { get; set; }

            [JsonProperty("price_tick", NullValueHandling = NullValueHandling.Ignore)]
            public string PriceTick { get; set; }

            [JsonProperty("instrument_value", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentValue { get; set; }

            [JsonProperty("settle_period", NullValueHandling = NullValueHandling.Ignore)]
            public int SettlePeriod { get; set; }

            [JsonProperty("funding_rate_cap", NullValueHandling = NullValueHandling.Ignore)]
            public int FundingRateCap { get; set; }

            [JsonProperty("funding_rate_floor", NullValueHandling = NullValueHandling.Ignore)]
            public int FundingRateFloor { get; set; }

            [JsonProperty("hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int HigNormalLimit { get; set; }

            [JsonProperty("min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int MinNormalLimit { get; set; }

            [JsonProperty("hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int HigOpenLimit { get; set; }

            [JsonProperty("min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int MinOpenLimit { get; set; }

            [JsonProperty("hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int HigTradeLimit { get; set; }

            [JsonProperty("min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int MinTradeLimit { get; set; }

            [JsonProperty("contract_infos", NullValueHandling = NullValueHandling.Ignore)]
            public List<ContractInfoObject> ContractInfos { get; set; }
        }

        public class ContractInfoObject
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public List<int> InstrumentType { get; set; }

            [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementDate { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateDate { get; set; }

            [JsonProperty("contract_status", NullValueHandling = NullValueHandling.Ignore)]
            public int ContractStatus { get; set; }
        }
    }
}