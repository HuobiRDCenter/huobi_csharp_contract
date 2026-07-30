using System.Collections.Generic;
using Huobi.SDK.Core.LinearSwap.WS.Response.Notify;
using Huobi.SDK.Core.WSBase;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.WS
{
    public class WSUnifiedNotifyClient
    {
        private string host = null;
        private string path = null;
        private string accessKey = null;
        private string secretKey = null;
        private Dictionary<string, WebSocketOp> allWsop = new Dictionary<string, WebSocketOp>();

        public WSUnifiedNotifyClient(string accessKey = null, string secretKey = null, string host = Host.FUTURES)
        {
            this.host = host;
            this.path = "/ws/v5/notification";
            this.accessKey = accessKey;
            this.secretKey = secretKey;
        }

        ~WSUnifiedNotifyClient()
        {
            foreach (var item in allWsop)
            {
                item.Value.Disconnect();
            }
            allWsop.Clear();
        }

        #region orders
        public delegate void _OnSubUnifiedOrdersResponse(SubUnifiedOrdersResponse data);

        public void SubOrders(string contractCode, _OnSubUnifiedOrdersResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            string key = $"orders.{contractCode}";
            WSUnifiedOpData opData = new WSUnifiedOpData { op = "sub", cid = cid, topic = "orders", contractCode = contractCode };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubUnifiedOrdersResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(key))
            {
                allWsop.Add(key, wsop);
            }
        }

        public void UnsubOrders(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            string key = $"orders.{contractCode}";
            WSUnifiedOpData opData = new WSUnifiedOpData { op = "unsub", cid = cid, topic = "orders", contractCode = contractCode };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if (!allWsop.ContainsKey(key))
            {
                return;
            }
            allWsop[key].SendMsg(unsub_str);
            allWsop.Remove(key);
        }
        #endregion
    }
}
