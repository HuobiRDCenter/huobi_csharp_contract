using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.WS.Response.Notify
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

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public SubContractElements Data { get; set; }
        
        public class SubContractElements
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_index_code", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentIndexCode { get; set; }

            [JsonProperty("real_time_settlement", NullValueHandling = NullValueHandling.Ignore)]
            public int RealTimeSettlement { get; set; }

            [JsonProperty("transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public int TransferProfitRatio { get; set; }
            
            [JsonProperty("settle_period", NullValueHandling = NullValueHandling.Ignore)]
            public int SettlePeriod { get; set; }

            [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
            public string MinLevel { get; set; }

            [JsonProperty("max_level", NullValueHandling = NullValueHandling.Ignore)]
            public string MaxLevel { get; set; }
            
            [JsonProperty("price_tick", NullValueHandling = NullValueHandling.Ignore)]
            public string PriceTick { get; set; }
            
            [JsonProperty("open_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string OpenOrderLimit { get; set; }
            
            [JsonProperty("offset_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string OffsetOrderLimit { get; set; }
            
            [JsonProperty("long_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string LongPositionLimit { get; set; }

            [JsonProperty("short_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string ShortPositionLimit { get; set; }
            
            [JsonProperty("funding_rate_cap", NullValueHandling = NullValueHandling.Ignore)]
            public string FundingRateCap { get; set; }

            [JsonProperty("funding_rate_floor", NullValueHandling = NullValueHandling.Ignore)]
            public string FundingRateFloor { get; set; }

            [JsonProperty("hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string HigNormalLimit { get; set; }

            [JsonProperty("min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string MinNormalLimit { get; set; }

            [JsonProperty("hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string HigOpenLimit { get; set; }

            [JsonProperty("min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string MinOpenLimit { get; set; }

            [JsonProperty("hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string HigTradeLimit { get; set; }

            [JsonProperty("min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string MinTradeLimit { get; set; }
            
            [JsonProperty("instrument_value", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentValue { get; set; }

            [JsonProperty("contract_infos", NullValueHandling = NullValueHandling.Ignore)]
            public List<ContractInfo> ContractInfos { get; set; }
        }

        public class ContractInfo
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("delivery_time", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryTime { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateDate { get; set; }

            [JsonProperty("contract_status", NullValueHandling = NullValueHandling.Ignore)]
            public int ContractStatus { get; set; }

            [JsonProperty("settlement_date", NullValueHandling = NullValueHandling.Ignore)]
            public string SettlementDate { get; set; }
        }
    }
}