﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.RESTful.Response.Account
{
    public class GetOrderLimitResponse
    {
        public string status { get; set; }

        [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode { get; set; }

        [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string errorMessage { get; set; }

        public long ts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Data data { get; set; }

        public class Data
        {
            [JsonProperty("order_price_type")]
            public string orderPriceType { get; set; }

            public List<OrderLimit> list { get; set; }

            public class OrderLimit
            {
                public string symbol { get; set; }

                public List<Types> types { get; set; }

                public class Types
                {

                    [JsonProperty("contract_type")]
                    public string contractType { get; set; }

                    [JsonProperty("open_limit")]
                    public double openLimit { get; set; }

                    [JsonProperty("close_limit")]
                    public double closeLimit { get; set; }
                }
            }
        }
    }
}
