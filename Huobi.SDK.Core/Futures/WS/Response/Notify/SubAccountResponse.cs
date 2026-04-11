using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.WS.Response.Notify
{
    /// <summary>
    /// 账户推送响应
    /// </summary>
    public class SubAccountResponse
    {
        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public string Op { get; set; }

        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountData> Data { get; set; }

        public class AccountData
        {
            [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
            public string State { get; set; }

            [JsonProperty("equity", NullValueHandling = NullValueHandling.Ignore)]
            public string Equity { get; set; }

            [JsonProperty("initial_margin", NullValueHandling = NullValueHandling.Ignore)]
            public string InitialMargin { get; set; }

            [JsonProperty("maintenance_margin", NullValueHandling = NullValueHandling.Ignore)]
            public string MaintenanceMargin { get; set; }

            [JsonProperty("maintenance_margin_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string MaintenanceMarginRate { get; set; }

            [JsonProperty("profit_unreal", NullValueHandling = NullValueHandling.Ignore)]
            public string ProfitUnreal { get; set; }

            [JsonProperty("available_margin", NullValueHandling = NullValueHandling.Ignore)]
            public string AvailableMargin { get; set; }

            [JsonProperty("voucher_value", NullValueHandling = NullValueHandling.Ignore)]
            public string VoucherValue { get; set; }

            [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedTime { get; set; }

            [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedTime { get; set; }

            [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
            public string Version { get; set; }

            [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
            public List<CurrencyDetail> Details { get; set; }
        }

        public class CurrencyDetail
        {
            [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
            public string Currency { get; set; }

            [JsonProperty("equity", NullValueHandling = NullValueHandling.Ignore)]
            public string Equity { get; set; }

            [JsonProperty("isolated_equity", NullValueHandling = NullValueHandling.Ignore)]
            public string IsolatedEquity { get; set; }

            [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
            public string Available { get; set; }

            [JsonProperty("withdraw_available", NullValueHandling = NullValueHandling.Ignore)]
            public string WithdrawAvailable { get; set; }

            [JsonProperty("profit_unreal", NullValueHandling = NullValueHandling.Ignore)]
            public string ProfitUnreal { get; set; }

            [JsonProperty("isolated_profit_unreal", NullValueHandling = NullValueHandling.Ignore)]
            public string IsolatedProfitUnreal { get; set; }

            [JsonProperty("initial_margin", NullValueHandling = NullValueHandling.Ignore)]
            public string InitialMargin { get; set; }

            [JsonProperty("maintenance_margin", NullValueHandling = NullValueHandling.Ignore)]
            public string MaintenanceMargin { get; set; }

            [JsonProperty("maintenance_margin_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string MaintenanceMarginRate { get; set; }

            [JsonProperty("initial_margin_rate", NullValueHandling = NullValueHandling.Ignore)]
            public string InitialMarginRate { get; set; }

            [JsonProperty("voucher", NullValueHandling = NullValueHandling.Ignore)]
            public string Voucher { get; set; }

            [JsonProperty("voucher_value", NullValueHandling = NullValueHandling.Ignore)]
            public string VoucherValue { get; set; }

            [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
            public string CreatedTime { get; set; }

            [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdatedTime { get; set; }
        }
    }
}