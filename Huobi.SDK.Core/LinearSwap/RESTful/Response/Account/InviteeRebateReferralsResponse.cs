using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Account
{
    public class InviteeRebateReferralsResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public long Ts { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ReferralData Data { get; set; }

        public class ReferralData
        {
            [JsonProperty("nextId", NullValueHandling = NullValueHandling.Ignore)]
            public long NextId { get; set; }

            [JsonProperty("rebateDetailList", NullValueHandling = NullValueHandling.Ignore)]
            public List<ReferralDetailVO> RebateDetailList { get; set; }
        }

        public class ReferralDetailVO
        {
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
            public int Id { get; set; }

            [JsonProperty("inviteUid", NullValueHandling = NullValueHandling.Ignore)]
            public int InviteUid { get; set; }

            [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
            public string Remark { get; set; }

            [JsonProperty("referralCode", NullValueHandling = NullValueHandling.Ignore)]
            public string ReferralCode { get; set; }

            [JsonProperty("inviteeType", NullValueHandling = NullValueHandling.Ignore)]
            public int InviteeType { get; set; }

            [JsonProperty("inviteeRebateRateSpotM2", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRateSpotM2 { get; set; }

            [JsonProperty("inviteeRebateRateContractM2", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRateContractM2 { get; set; }

            [JsonProperty("inviteeRebateRatePartnerSpot", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRatePartnerSpot { get; set; }

            [JsonProperty("inviteeRebateRatePartnerContract", NullValueHandling = NullValueHandling.Ignore)]
            public string InviteeRebateRatePartnerContract { get; set; }

            [JsonProperty("joinTimeM2", NullValueHandling = NullValueHandling.Ignore)]
            public long JoinTimeM2 { get; set; }

            [JsonProperty("joinTimePartner", NullValueHandling = NullValueHandling.Ignore)]
            public long JoinTimePartner { get; set; }

            [JsonProperty("spotTradingVolume", NullValueHandling = NullValueHandling.Ignore)]
            public string SpotTradingVolume { get; set; }

            [JsonProperty("futuresTradingVolume", NullValueHandling = NullValueHandling.Ignore)]
            public string FuturesTradingVolume { get; set; }
        }
    }
}