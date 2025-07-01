using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class InviteeRebateAllRebateDtailResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("invitee_uid", NullValueHandling = NullValueHandling.Ignore)]
        public int? InviteeUid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public RebateAllRebateDtail Data { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("nextId", NullValueHandling = NullValueHandling.Ignore)]
        public string NextId { get; set; }
        
        public class RebateAllRebateDtail
        {
            [JsonProperty("invitee_type", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeType { get; set; }

            [JsonProperty("invitee_rebate_rate_spot_m2", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRateSpotM2 { get; set; }

            [JsonProperty("invitee_rebate_rate_contract_m2", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRateContractM2 { get; set; }

            [JsonProperty("invitee_rebate_rate_partner_spot", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRatePartnerSpot { get; set; }

            [JsonProperty("invitee_rebate_rate_partner_contract", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRatePartnerContract { get; set; }

            [JsonProperty("join_time_m2", NullValueHandling = NullValueHandling.Ignore)]
            public string JoinTimeM2 { get; set; }

            [JsonProperty("join_time_partner", NullValueHandling = NullValueHandling.Ignore)]
            public string JoinTimePartner { get; set; }

            [JsonProperty("Invitee_total_commission_usdt", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeTotalCommissionUsdt { get; set; }

            [JsonProperty("Invitee_total_commission_trx", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeTotalCommissionTrx { get; set; }

            [JsonProperty("Invitee_total_commission_htx", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeTotalCommissionHtx { get; set; }

            [JsonProperty("partner_total_commission_usdt", NullValueHandling = NullValueHandling.Ignore)]
            public string PartnerTotalCommissionUsdt { get; set; }

            [JsonProperty("partner_total_commission_trx", NullValueHandling = NullValueHandling.Ignore)]
            public string PartnerTotalCommissionTrx { get; set; }

            [JsonProperty("partner_total_commission_htx", NullValueHandling = NullValueHandling.Ignore)]
            public string PartnerTotalCommissionHtx { get; set; }
        }
    }
}