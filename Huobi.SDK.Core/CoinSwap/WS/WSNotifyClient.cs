﻿using System.Collections.Generic;
using Huobi.SDK.Core.CoinSwap.WS.Response.Notify;
using Huobi.SDK.Core.WSBase;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.WS
{
    public class WSNotifyClient
    {
        private string host = null;
        private string path = null;
        private string accessKey = null;
        private string secretKey = null;
        private Dictionary<string, WebSocketOp> allWsop = new Dictionary<string, WebSocketOp>();

        public WSNotifyClient(string accessKey = null, string secretKey = null, string host = Host.FUTURES)
        {
            this.host = host;
            this.path = "/swap-notification";
            this.accessKey = accessKey;
            this.secretKey = secretKey;
        }

        ~WSNotifyClient()
        {
            foreach (var item in allWsop)
            {
                item.Value.Disconnect();
            }
            allWsop.Clear();
        }

        #region orders
        public delegate void _OnSubOrdersResponse(SubOrdersResponse data);

        /// <summary>
        ///  margin sub orders
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        public void SubOrders(string contractCode, _OnSubOrdersResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"orders.{contractCode}";
            WSOpData opData = new WSOpData { op = "sub", topic = ch };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubOrdersResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        ///  margin unsub orders
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        public void UnsubOrders(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"orders.{contractCode}";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region accounts
        public delegate void _OnSubAccountsResponse(SubAccountsResponse data);

        /// <summary>
        ///  margin sub accounts
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        public void SubAcounts(string contractCode, _OnSubAccountsResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"accounts.{contractCode}";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubAccountsResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        ///  margin unsub accounts
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        public void UnsubAccounts(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"accounts.{contractCode}";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region positions
        public delegate void _OnSubPositionsResponse(SubPositionsResponse data);

        /// <summary>
        ///  margin sub positions
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        public void SubPositions(string contractCode, _OnSubPositionsResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"positions.{contractCode}";
            WSOpData opData = new WSOpData { op = "sub", topic = ch };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubPositionsResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        ///  margin unsub positions
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        public void UnsubPositions(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"positions.{contractCode}";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region match orders
        public delegate void _OnSubMatchOrdersResponse(SubOrdersResponse data);

        /// <summary>
        ///  margin sub match orders
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        public void SubMatchOrders(string contractCode, _OnSubMatchOrdersResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            contractCode = contractCode.ToLower();
            string ch = $"matchOrders.{contractCode}";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubOrdersResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        ///  margin unsub match orders
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        public void UnsubMathOrders(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            contractCode = contractCode.ToLower();
            string ch = $"matchOrders.{contractCode}";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region liquidation orders
        public delegate void _OnSubLiquidationOrdersResponse(SubLiquidationOrdersResponse data);

        /// <summary>
        /// sub liquidation orders
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        /// <param name="businessType"></param>
        public void SubLiquidationOrders(string contractCode, _OnSubLiquidationOrdersResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID,
                                         string businessType = null)
        {
            string ch = $"public.{contractCode}.liquidation_orders";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch, businessType = businessType };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubLiquidationOrdersResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        /// unsub liquidation orders
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        /// <param name="businessType"></param>
        public void UnsubLiquidationOrders(string contractCode, string cid = WebSocketOp.DEFAULT_ID,
                                           string businessType = null)
        {
            string ch = $"public.{contractCode}.liquidation_orders";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch, businessType = businessType };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region funding rate
        public delegate void _OnSubFundingRateResponse(SubFundingRateResponse data);

        /// <summary>
        /// sub funding rate
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        public void SubFundingRate(string contractCode, _OnSubFundingRateResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"public.{contractCode}.funding_rate";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubFundingRateResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        /// unsub funding rate
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        public void UnsubFundingRate(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"public.{contractCode}.funding_rate";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region fcontract info
        public delegate void _OnSubContractInfoResponse(SubContractInfoResponse data);

        /// <summary>
        /// sub contract info
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        /// <param name="businessType"></param>
        public void SubContractInfo(string contractCode, _OnSubContractInfoResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID,
                                    string businessType = null)
        {
            string ch = $"public.{contractCode}.contract_info";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch, businessType = businessType };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubContractInfoResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        /// unsub contract info
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        /// <param name="businessType"></param>
        public void UnsubContractInfo(string contractCode, string cid = WebSocketOp.DEFAULT_ID, string businessType = null)
        {
            string ch = $"public.{contractCode}.contract_info";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch, businessType = businessType };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region trigger order
        public delegate void _OnSubTriggerOrderResponse(SubTriggerOrderResponse data);

        /// <summary>
        ///  margin sub trigger order
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        public void SubTriggerOrder(string contractCode, _OnSubTriggerOrderResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"trigger_order.{contractCode}";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubTriggerOrderResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        ///  margin unsub trigger order
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        public void UnsubTriggerOrder(string contractCode, string cid = WebSocketOp.DEFAULT_ID)
        {
            string ch = $"trigger_order.{contractCode}";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion

        #region contract elements
        public delegate void _OnSubContractElementsResponse(SubContractElementsResponse data);

        /// <summary>
        /// sub contract elements
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="callbackFun"></param>
        /// <param name="cid"></param>
        /// <param name="businessType"></param>
        /// <param name="tradePartition"></param>
        public void SubContractElements(string contractCode, _OnSubContractElementsResponse callbackFun, string cid = WebSocketOp.DEFAULT_ID,
                                         string businessType = null, string tradePartition = null)
        {
            string ch = $"public.{contractCode}.contract_elements";
            WSOpData opData = new WSOpData { op = "sub", cid = cid, topic = ch, businessType = businessType, tradePartition = tradePartition };
            string sub_str = JsonConvert.SerializeObject(opData);

            WebSocketOp wsop = new WebSocketOp(this.path, sub_str, callbackFun, typeof(SubContractElementsResponse), true, this.host,
                                            this.accessKey, this.secretKey);
            wsop.Connect();
            if (!allWsop.ContainsKey(ch))
            {
                allWsop.Add(ch, wsop);
            }
        }

        /// <summary>
        /// unsub contract elements
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="cid"></param>
        /// <param name="businessType"></param>
        /// <param name="tradePartition"></param>
        public void UnsubContractElements(string contractCode, string cid = WebSocketOp.DEFAULT_ID,
                                           string businessType = null, string tradePartition = null)
        {
            string ch = $"public.{contractCode}.contract_elements";
            WSOpData opData = new WSOpData { op = "unsub", cid = cid, topic = ch, businessType = businessType, tradePartition = tradePartition };
            string unsub_str = JsonConvert.SerializeObject(opData);

            if(!allWsop.ContainsKey(ch))
            {
                return;
            }
            allWsop[ch].SendMsg(unsub_str);
            allWsop.Remove(ch);
        }
        #endregion
    }
}