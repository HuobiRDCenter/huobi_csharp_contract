using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Common
{
    public class ContractQueryElementsResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContractQueryElements> Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }
        
        public class ContractQueryElements
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_index_code", NullValueHandling = NullValueHandling.Ignore)]
            public string InstrumentIndexCode { get; set; }

            [JsonProperty("real_time_settlement", NullValueHandling = NullValueHandling.Ignore)]
            public int RealTimeSettlement { get; set; }

            [JsonProperty("contract_infos", NullValueHandling = NullValueHandling.Ignore)]
            public List<ContractInfoObject> ContractInfos { get; set; }

            [JsonProperty("transfer_profit_ratio", NullValueHandling = NullValueHandling.Ignore)]
            public object TransferProfitRatio { get; set; }

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

            [JsonProperty("short_position_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int ShortPositionLimit { get; set; }

            [JsonProperty("week_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int WeekHigNormalLimit { get; set; }

            [JsonProperty("week_min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int WeekMinNormalLimit { get; set; }

            [JsonProperty("week_hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int WeekHigOpenLimit { get; set; }

            [JsonProperty("week_min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int WeekMinOpenLimit { get; set; }

            [JsonProperty("week_hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int WeekHigTradeLimit { get; set; }

            [JsonProperty("week_min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int WeekMinTradeLimit { get; set; }

            [JsonProperty("biweek_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int BiweekHigNormalLimit { get; set; }

            [JsonProperty("biweek_min_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int BiweekMinNormalLimit { get; set; }

            [JsonProperty("biweek_hig_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int BiweekHigOpenLimit { get; set; }

            [JsonProperty("biweek_min_open_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int BiweekMinOpenLimit { get; set; }

            [JsonProperty("biweek_hig_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int BiweekHigTradeLimit { get; set; }

            [JsonProperty("biweek_min_trade_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int BiweekMinTradeLimit { get; set; }

            [JsonProperty("quarter_hig_normal_limit", NullValueHandling = NullValueHandling.Ignore)]
            public int QuarterHigNormalLimit { get; set; }

            [JsonProperty("quarter_min_normal_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int QuarterMinNormalLimit { get; set; }

            [JsonProperty("quarter_hig_open_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int QuarterHigOpenLimit { get; set; }

            [JsonProperty("quarter_min_open_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int QuarterMinOpenLimit { get; set; }

            [JsonProperty("quarter_hig_trade_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int QuarterHigTradeLimit { get; set; }

            [JsonProperty("quarter_min_trade_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int QuarterMinTradeLimit { get; set; }

            [JsonProperty("biquarter_hig_normal_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int BiquarterHigNormalLimit { get; set; }

            [JsonProperty("biquarter_min_normal_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int BiquarterMinNormalLimit { get; set; }

            [JsonProperty("biquarter_hig_open_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int BiquarterHigOpenLimit { get; set; }

            [JsonProperty("biquarter_min_open_limit",NullValueHandling =NullValueHandling.Ignore)]
            public int BiquarterMinOpenLimit { get; set; }

            [JsonProperty("biquarter_hig_trade_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int BiquarterHigTradeLimit { get; set; }

            [JsonProperty("biquarter_min_trade_limit", NullValueHandling =NullValueHandling.Ignore)]
            public int BiquarterMinTradeLimit { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int[] InstrumentType { get; set; }

            [JsonProperty("order_limits", NullValueHandling = NullValueHandling.Ignore)]
            public List<OrderLimitObject> OrderLimits { get; set; }
        }

        public class ContractInfoObject
        {
            [JsonProperty("contract_code", NullValueHandling = NullValueHandling.Ignore)]
            public string ContractCode { get; set; }

            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateDate { get; set; }

            [JsonProperty("contract_status", NullValueHandling = NullValueHandling.Ignore)]
            public int ContractStatus { get; set; }

            [JsonProperty("delivery_time", NullValueHandling = NullValueHandling.Ignore)]
            public string DeliveryTime { get; set; }

            [JsonProperty("delivery_date", NullValueHandling =NullValueHandling.Ignore)]
            public string DeliveryDate { get; set; }
        }

        public class OrderLimitObject
        {
            [JsonProperty("instrument_type", NullValueHandling = NullValueHandling.Ignore)]
            public int InstrumentType { get; set; }

            [JsonProperty("open", NullValueHandling = NullValueHandling.Ignore)]
            public string Open { get; set; }

            [JsonProperty("close", NullValueHandling =NullValueHandling.Ignore)]
            public string Close { get; set; }
        }
    }
}