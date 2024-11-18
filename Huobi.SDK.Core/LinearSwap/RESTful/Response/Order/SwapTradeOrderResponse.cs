using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Account;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Order
{
    public class SwapTradeOrderResponse
    {
        public int code  { get; set; }
        
        public string message { get; set; }

        public long ts { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SwapMultiAssetsMarginResponse.Data> data { get; set; }

        public class Data
        {
            /// <summary>
            /// 订单ID
            /// </summary>
            [JsonProperty("order_id")]
            public string OrderId { get; set; }

            /// <summary>
            /// 用户下单时填写的客户端订单ID，没填则不返回
            /// </summary>
            [JsonProperty("client_order_id")]
            public string ClientOrderId { get; set; }
        }
    }
}