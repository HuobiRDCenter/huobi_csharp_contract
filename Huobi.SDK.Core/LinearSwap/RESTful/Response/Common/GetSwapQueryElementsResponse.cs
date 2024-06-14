using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Common
{
    public class GetSwapQueryElementsResponse
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

            [JsonProperty("mode_type", NullValueHandling = NullValueHandling.Ignore)]
            public int ModeType { get; set; }

            [JsonProperty("swap_delivery_type", NullValueHandling = NullValueHandling.Ignore)]
            public int SwapDeliveryType { get; set; }

            [JsonProperty("instrument_index_code", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentIndexCode { get; set; }

            [JsonProperty("real_time_settlement", NullValueHandling = NullValueHandling.Ignore)]
            public int RealTimeSettlement { get; set; }

            [JsonProperty("transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public object TransferProfitRatio { get; set; }

            [JsonProperty("cross_transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public object CrossTransferProfitRatio { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public List<int> InstrumentType { get; set; }

            [JsonProperty("trade_partition", NullValueHandling = NullValueHandling.Ignore)]
            public string TradePartition { get; set; }

            [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
            public int MinLevel { get; set; }

            [JsonProperty("max_level", NullValueHandling = NullValueHandling.Ignore)]
            public int MaxLevel { get; set; }

            [JsonProperty("settle_period", NullValueHandling = NullValueHandling.Ignore)]
            public int SettlePeriod { get; set; }

            [JsonProperty("funding_rate_cap", NullValueHandling = NullValueHandling.Ignore)]
            public int FundingRateCap { get; set; }

            [JsonProperty("funding_rate_floor", NullValueHandling = NullValueHandling.Ignore)]
            public int FundingRateFloor { get; set; }

            [JsonProperty("long_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public object LongPositionLimit { get; set; }

            [JsonProperty("offset_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public object OffsetOrderLimit { get; set; }

            [JsonProperty("open_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public object OpenOrderLimit { get; set; }

            [JsonProperty("short_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public object ShortPositionLimit { get; set; }

            [JsonProperty("contract_infos", NullValueHandling = NullValueHandling.Ignore)]
            public List<ContractInfoObject> ContractInfos { get; set; }

            [JsonProperty("price_ticks", NullValueHandling = NullValueHandling.Ignore)]
            public List<PriceTickObject> PriceTicks { get; set; }

            [JsonProperty("instrument_values", NullValueHandling = NullValueHandling.Ignore)]
            public List<InstrumentValueObject> InstrumentValues { get; set; }

            [JsonProperty("order_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<OrderLimitObject> OrderLimits { get; set; }

            [JsonProperty("normal_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<NormalLimitObject> NormalLimits { get; set; }

            [JsonProperty("open_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<OpenLimitObject> OpenLimits { get; set; }

            [JsonProperty("trade_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<TradeLimitObject> TradeLimits { get; set; }
        }

        public class ContractInfoObject
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public List<int> InstrumentType { get; set; }

            [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementDate { get; set; }

            [JsonProperty("delivery_time", NullValueHandling =NullValueHandling.Ignore)]
            public string DeliveryTime { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateDate { get; set; }

            [JsonProperty("contract_status", NullValueHandling = NullValueHandling.Ignore)]
            public int ContractStatus { get; set; }

            [JsonProperty("delivery_date", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryDate { get; set; }
        }

        public class PriceTickObject
        {
            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public int BusinessType { get; set; }

            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public string Price { get; set; }
        }

        public class InstrumentValueObject
        {
            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public int BusinessType { get; set; }

            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public string Price { get; set; }
        }

        public class OrderLimitObject
        {
            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
            public string Open { get; set; }

            [JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
            public string Close { get; set; }

            [JsonProperty("open_after_closing", NullValueHandling = NullValueHandling.Ignore)]
            public string OpenAfterClosing { get; set; }
        }

        public class NormalLimitObject
        {
            [JsonProperty("instrument_type", NullValueHandling =NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
            public string Open { get; set; }

            [JsonProperty("close", NullValueHandling =NullValueHandling.Ignore)]
            public string Close { get; set; }
        }

        public class OpenLimitObject
        {
            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("open", NullValueHandling =NullValueHandling.Ignore)]
            public string Open { get; set; }

            [JsonProperty("close", NullValueHandling =NullValueHandling.Ignore)]
            public string Close { get; set; }
        }

        public class TradeLimitObject
        {
            [JsonProperty("instrument_type", NullValueHandling =NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("open", NullValueHandling =NullValueHandling.Ignore)]
            public string Open { get; set; }

            [JsonProperty("close", NullValueHandling =NullValueHandling.Ignore)]
            public string Close { get; set; }
        }
    }
}