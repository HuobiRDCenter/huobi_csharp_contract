using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.WS.Response.Notify
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
            
            [JsonProperty("price_tick", NullValueHandling = NullValueHandling.Ignore)]
            public string PriceTick { get; set; }
            
            [JsonProperty("instrument_value", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentValue { get; set; }

            [JsonProperty("real_time_settlement", NullValueHandling = NullValueHandling.Ignore)]
            public int RealTimeSettlement { get; set; }

            [JsonProperty("transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public decimal TransferProfitRatio { get; set; }

            [JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
            public string MinLevel { get; set; }

            [JsonProperty("max_level", NullValueHandling = NullValueHandling.Ignore)]
            public string MaxLevel { get; set; }
            
            [JsonProperty("open_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string OpenOrderLimit { get; set; }

            [JsonProperty("offset_order_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string OffsetOrderLimit { get; set; }

            [JsonProperty("long_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string LongPositionLimit { get; set; }

            [JsonProperty("short_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public string ShortPositionLimit { get; set; }

            [JsonProperty("week_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double WeekHigNormalLimit { get; set; }

            [JsonProperty("week_min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double WeekMinNormalLimit { get; set; }

            [JsonProperty("week_hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double WeekHigOpenLimit { get; set; }

            [JsonProperty("week_min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double WeekMinOpenLimit { get; set; }

            [JsonProperty("week_hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double WeekHigTradeLimit { get; set; }

            [JsonProperty("week_min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double WeekMinTradeLimit { get; set; }

            [JsonProperty("biweek_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiweekHigNormalLimit { get; set; }

            [JsonProperty("biweek_min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiweekMinNormalLimit { get; set; }

            [JsonProperty("biweek_hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiweekHigOpenLimit { get; set; }

            [JsonProperty("biweek_min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiweekMinOpenLimit { get; set; }

            [JsonProperty("biweek_hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiweekHigTradeLimit { get; set; }
            
            [JsonProperty("quarter_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double QuarterHigNormalLimit { get; set; }
            
            [JsonProperty("quarter_min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double QuarterMinNormalLimit { get; set; }
            
            [JsonProperty("quarter_hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double QuarterHigOpenLimit { get; set; }
            
            [JsonProperty("quarter_min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double QuarterMinOpenLimit { get; set; }
            
            [JsonProperty("quarter_hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double QuarterHigTradeLimit { get; set; }
            
            [JsonProperty("quarter_min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double QuarterMinTradeLimit { get; set; }
            
            [JsonProperty("biquarter_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiquarterHigNormalLimit { get; set; }
            
            [JsonProperty("biquarter_min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiquarterMinNormalLimit { get; set; }
            
            [JsonProperty("biquarter_hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiquarterHigOpenLimit { get; set; }
            
            [JsonProperty("biquarter_min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiquarterMinOpenLimit { get; set; }
            
            [JsonProperty("biquarter_hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiquarterHigTradeLimit { get; set; }
            
            [JsonProperty("biquarter_min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public double BiquarterMinTradeLimit { get; set; }

            [JsonProperty("contract_infos", NullValueHandling = NullValueHandling.Ignore)]
            public List<ContractInfoEntity> ContractInfos { get; set; }

            [JsonProperty("order_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<OrderLimitEntity> OrderLimits { get; set; }
        }

        public class ContractInfoEntity
        {
            [JsonProperty("delivery_time", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryTime { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateDate { get; set; }

            [JsonProperty("contract_status", NullValueHandling = NullValueHandling.Ignore)]
            public int ContractStatus { get; set; }

            [JsonProperty("delivery_date", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryDate { get; set; }

            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public List<int> InstrumentType { get; set; }

            
        }
        public class OrderLimitEntity
        {
            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }
            [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
            public string Open { get; set; }
            [JsonProperty("close", NullValueHandling = NullValueHandling.Ignore)]
            public string Close { get; set; }
        }

    }
}