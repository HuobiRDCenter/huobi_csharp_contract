using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.WS.Response.Notify
{
    public class SubContractElementsResponse
    {
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public string Op { get; set; }
        
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        public class SubContractElements
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
            public decimal TransferProfitRatio { get; set; }

            [JsonProperty("cross_transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public decimal CrossTransferProfitRatio { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public List<int> InstrumentType { get; set; }

            [JsonProperty("trade_partition", NullValueHandling = NullValueHandling.Ignore)]
            public string TradePartition { get; set; }

            [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
            public string MinLevel { get; set; }

            [JsonProperty("max_level", NullValueHandling = NullValueHandling.Ignore)]
            public string MaxLevel { get; set; }

            [JsonProperty("settle_period", NullValueHandling = NullValueHandling.Ignore)]
            public int SettlePeriod { get; set; }

            [JsonProperty("funding_rate_cap", NullValueHandling = NullValueHandling.Ignore)]
            public double FundingRateCap { get; set; }

            [JsonProperty("funding_rate_floor", NullValueHandling = NullValueHandling.Ignore)]
            public double FundingRateFloor { get; set; }

            [JsonProperty("contract_infos", NullValueHandling = NullValueHandling.Ignore)]
            public List<ContractInfo> ContractInfos { get; set; }

            [JsonProperty("price_ticks", NullValueHandling = NullValueHandling.Ignore)]
            public List<PriceTick> PriceTicks { get; set; }

            [JsonProperty("instrument_values", NullValueHandling = NullValueHandling.Ignore)]
            public List<InstrumentValue> InstrumentValues { get; set; }

            [JsonProperty("order_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<OrderLimit> OrderLimits { get; set; }
            
            [JsonProperty("normal_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<NormalLimit> NormalLimits { get; set; }
            
            [JsonProperty("open_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<NormalLimit> OpenLimits { get; set; }
            
            [JsonProperty("trade_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<NormalLimit> TradeLimits { get; set; }
            
            [JsonProperty("price_tick", NullValueHandling = NullValueHandling.Ignore)]
            public string PriceTick { get; set; }
            
            [JsonProperty("instrument_value", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentValue { get; set; }
            
            [JsonProperty("offset_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string OffsetOrderLimit { get; set; }
            
            [JsonProperty("long_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string LongPositionLimit { get; set; }
            
            [JsonProperty("short_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string ShortPositionLimit { get; set; }
        }

        public class NormalLimit
        {
            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }
            
            [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
            public string Open { get; set; }
            
            [JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
            public string Close { get; set; }
        }

        public class PriceTick
        {
            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public int BusinessType { get; set; }
            
            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public string Price { get; set; }
        }
        
        
        public class ContractInfo
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementDate { get; set; }

            [JsonProperty("delivery_time", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryTime { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateDate { get; set; }

            [JsonProperty("contract_status", NullValueHandling = NullValueHandling.Ignore)]
            public int ContractStatus { get; set; }

            [JsonProperty("delivery_date", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryDate { get; set; }
        }

        public class InstrumentValue
        {
            [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
            public int BusinessType { get; set; }

            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
            public string Price { get; set; }
        }

        public class OrderLimit
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
    }
}