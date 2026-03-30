using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Algo;

namespace Huobi.SDK.Core.LinearSwap.RESTful
{
    /// <summary>
    /// 策略委托相关接口
    /// </summary>
    public class AlgoClient
    {
        private const string GET_METHOD = "GET";
        private const string POST_METHOD = "POST";

        private readonly PrivateUrlBuilder _urlBuilder;

        public AlgoClient(string accessKey, string secretKey, string host = Host.FUTURES)
        {
            _urlBuilder = new PrivateUrlBuilder(accessKey, secretKey, host);
        }

        /// <summary>
        /// 策略委托下单
        /// </summary>
        /// <param name="contractCode">合约代码</param>
        /// <param name="type">策略类型</param>
        /// <param name="positionSide">仓位方向</param>
        /// <param name="side">买卖方向</param>
        /// <param name="marginMode">保证金模式</param>
        /// <param name="algoClientOrderId">用户自定义策略ID</param>
        /// <param name="volume">委托数量</param>
        /// <param name="tpTriggerPrice">止盈触发价</param>
        /// <param name="tpOrderPrice">止盈委托价</param>
        /// <param name="tpType">止盈委托类型</param>
        /// <param name="tpTriggerPriceType">止盈触发价类型</param>
        /// <param name="slTriggerPrice">止损触发价</param>
        /// <param name="slOrderPrice">止损委托价</param>
        /// <param name="slType">止损委托类型</param>
        /// <param name="slTriggerPriceType">止损触发价类型</param>
        /// <param name="price">委托价格</param>
        /// <param name="priceMatch">价格匹配</param>
        /// <param name="triggerPrice">触发价</param>
        /// <param name="triggerPriceType">触发价类型</param>
        /// <param name="activePrice">激活价</param>
        /// <param name="orderPriceType">委托价格类型</param>
        /// <param name="callbackRate">回调幅度</param>
        /// <param name="reduceOnly">是否只减仓</param>
        /// <returns></returns>
        public async Task<AlgoOrderResponse> AlgoOrderAsync(
            string contractCode,
            string type,
            string positionSide,
            string side,
            string marginMode,
            string algoClientOrderId = null,
            string volume = null,
            string tpTriggerPrice = null,
            string tpOrderPrice = null,
            string tpType = null,
            string tpTriggerPriceType = null,
            string slTriggerPrice = null,
            string slOrderPrice = null,
            string slType = null,
            string slTriggerPriceType = null,
            string price = null,
            string priceMatch = null,
            string triggerPrice = null,
            string triggerPriceType = null,
            string activePrice = null,
            string orderPriceType = null,
            string callbackRate = null,
            bool? reduceOnly = null)
        {
            // url
            string url = _urlBuilder.Build(POST_METHOD, "/v5/algo/order");

            // content
            string content = null;
            
            // 必填参数
            if (!string.IsNullOrEmpty(contractCode))
            {
                content += $",\"contract_code\": \"{contractCode}\"";
            }
            if (!string.IsNullOrEmpty(type))
            {
                content += $",\"type\": \"{type}\"";
            }
            if (!string.IsNullOrEmpty(positionSide))
            {
                content += $",\"position_side\": \"{positionSide}\"";
            }
            if (!string.IsNullOrEmpty(side))
            {
                content += $",\"side\": \"{side}\"";
            }
            if (!string.IsNullOrEmpty(marginMode))
            {
                content += $",\"margin_mode\": \"{marginMode}\"";
            }

            // 可选参数
            if (!string.IsNullOrEmpty(algoClientOrderId))
            {
                content += $",\"algo_client_order_id\": \"{algoClientOrderId}\"";
            }
            if (!string.IsNullOrEmpty(volume))
            {
                content += $",\"volume\": \"{volume}\"";
            }

            // 止盈相关参数
            if (!string.IsNullOrEmpty(tpTriggerPrice))
            {
                content += $",\"tp_trigger_price\": \"{tpTriggerPrice}\"";
            }
            if (!string.IsNullOrEmpty(tpOrderPrice))
            {
                content += $",\"tp_order_price\": \"{tpOrderPrice}\"";
            }
            if (!string.IsNullOrEmpty(tpType))
            {
                content += $",\"tp_type\": \"{tpType}\"";
            }
            if (!string.IsNullOrEmpty(tpTriggerPriceType))
            {
                content += $",\"tp_trigger_price_type\": \"{tpTriggerPriceType}\"";
            }

            // 止损相关参数
            if (!string.IsNullOrEmpty(slTriggerPrice))
            {
                content += $",\"sl_trigger_price\": \"{slTriggerPrice}\"";
            }
            if (!string.IsNullOrEmpty(slOrderPrice))
            {
                content += $",\"sl_order_price\": \"{slOrderPrice}\"";
            }
            if (!string.IsNullOrEmpty(slType))
            {
                content += $",\"sl_type\": \"{slType}\"";
            }
            if (!string.IsNullOrEmpty(slTriggerPriceType))
            {
                content += $",\"sl_trigger_price_type\": \"{slTriggerPriceType}\"";
            }

            // 计划委托相关参数
            if (!string.IsNullOrEmpty(price))
            {
                content += $",\"price\": \"{price}\"";
            }
            if (!string.IsNullOrEmpty(priceMatch))
            {
                content += $",\"price_match\": \"{priceMatch}\"";
            }
            if (!string.IsNullOrEmpty(triggerPrice))
            {
                content += $",\"trigger_price\": \"{triggerPrice}\"";
            }
            if (!string.IsNullOrEmpty(triggerPriceType))
            {
                content += $",\"trigger_price_type\": \"{triggerPriceType}\"";
            }

            // 跟踪委托相关参数
            if (!string.IsNullOrEmpty(activePrice))
            {
                content += $",\"active_price\": \"{activePrice}\"";
            }
            if (!string.IsNullOrEmpty(orderPriceType))
            {
                content += $",\"order_price_type\": \"{orderPriceType}\"";
            }
            if (!string.IsNullOrEmpty(callbackRate))
            {
                content += $",\"callback_rate\": \"{callbackRate}\"";
            }
            if (reduceOnly != null)
            {
                content += $",\"reduce_only\": {(reduceOnly.Value ? "true" : "false")}";
            }

            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }

            return await HttpRequest.PostAsync<AlgoOrderResponse>(url, content);
        }

        /// <summary>
        /// 撤销策略委托订单
        /// </summary>
        /// <param name="contractCode">合约代码</param>
        /// <param name="algoId">策略ID</param>
        /// <param name="algoClientOrderId">用户自定义策略ID</param>
        /// <returns></returns>
        public async Task<CancelAlgoOrdersResponse> CancelAlgoOrderAsync(
            string contractCode = null,
            string algoId = null,
            string algoClientOrderId = null)
        {
            // url
            string url = _urlBuilder.Build(POST_METHOD, "/v5/algo/cancel-orders");

            // content
            string content = null;
            
            if (!string.IsNullOrEmpty(algoId))
            {
                content += $",\"algo_id\": \"{algoId}\"";
            }
            if (!string.IsNullOrEmpty(algoClientOrderId))
            {
                content += $",\"algo_client_order_id\": \"{algoClientOrderId}\"";
            }
            if (!string.IsNullOrEmpty(contractCode))
            {
                content += $",\"contract_code\": \"{contractCode}\"";
            }

            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }

            return await HttpRequest.PostAsync<CancelAlgoOrdersResponse>(url, content);
        }

        /// <summary>
        /// 查询策略委托订单
        /// </summary>
        /// <param name="type">策略类型，必填</param>
        /// <param name="algoId">策略ID</param>
        /// <param name="algoClientOrderId">用户自定义策略ID</param>
        /// <param name="contractCode">合约代码</param>
        /// <returns></returns>
        public async Task<QueryAlgoOrdersResponse> QueryAlgoOrderAsync(
            string type,
            string algoId = null,
            string algoClientOrderId = null,
            string contractCode = null)
        {
            // location
            string location = "/v5/algo/order";

            // option
            string option = null;
            
            if (!string.IsNullOrEmpty(type))
            {
                option += $"&type={type}";
            }
            if (!string.IsNullOrEmpty(algoId))
            {
                option += $"&algo_id={algoId}";
            }
            if (!string.IsNullOrEmpty(algoClientOrderId))
            {
                option += $"&algo_client_order_id={algoClientOrderId}";
            }
            if (!string.IsNullOrEmpty(contractCode))
            {
                option += $"&contract_code={contractCode}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<QueryAlgoOrdersResponse>(url);
        }

        /// <summary>
        /// 查询当前未触发策略订单
        /// </summary>
        /// <param name="type">策略类型，必填</param>
        /// <param name="contractCode">合约代码</param>
        /// <param name="algoId">策略ID</param>
        /// <param name="algoClientOrderId">用户自定义策略ID</param>
        /// <param name="from">起始ID</param>
        /// <param name="limit">数量限制</param>
        /// <param name="direct">查询方向</param>
        /// <returns></returns>
        public async Task<QueryOpenAlgoOrdersResponse> QueryOpenAlgoOrdersAsync(
            string type,
            string contractCode = null,
            string algoId = null,
            string algoClientOrderId = null,
            long? from = null,
            int? limit = null,
            string direct = null)
        {
            // location
            string location = "/v5/algo/order/opens";

            // option
            string option = null;
            
            if (!string.IsNullOrEmpty(type))
            {
                option += $"&type={type}";
            }
            if (!string.IsNullOrEmpty(contractCode))
            {
                option += $"&contract_code={contractCode}";
            }
            if (!string.IsNullOrEmpty(algoId))
            {
                option += $"&algo_id={algoId}";
            }
            if (!string.IsNullOrEmpty(algoClientOrderId))
            {
                option += $"&algo_client_order_id={algoClientOrderId}";
            }
            if (from != null)
            {
                option += $"&from={from}";
            }
            if (limit != null)
            {
                option += $"&limit={limit}";
            }
            if (!string.IsNullOrEmpty(direct))
            {
                option += $"&direct={direct}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<QueryOpenAlgoOrdersResponse>(url);
        }

        /// <summary>
        /// 查询历史策略订单
        /// </summary>
        /// <param name="type">策略类型，必填</param>
        /// <param name="contractCode">合约代码</param>
        /// <param name="marginMode">保证金模式</param>
        /// <param name="states">订单状态列表</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="from">起始ID</param>
        /// <param name="limit">数量限制</param>
        /// <param name="direct">查询方向</param>
        /// <returns></returns>
        public async Task<QueryAlgoOrderHistoryResponse> QueryAlgoOrderHistoryAsync(
            string type,
            string contractCode = null,
            string marginMode = null,
            List<string> states = null,
            long? startTime = null,
            long? endTime = null,
            long? from = null,
            int? limit = null,
            string direct = null)
        {
            // location
            string location = "/v5/algo/order/history";

            // option
            string option = null;
            
            if (!string.IsNullOrEmpty(type))
            {
                option += $"&type={type}";
            }
            if (!string.IsNullOrEmpty(contractCode))
            {
                option += $"&contract_code={contractCode}";
            }
            if (!string.IsNullOrEmpty(marginMode))
            {
                option += $"&margin_mode={marginMode}";
            }
            if (states != null && states.Count > 0)
            {
                option += $"&states={string.Join(",", states)}";
            }
            if (startTime != null)
            {
                option += $"&start_time={startTime}";
            }
            if (endTime != null)
            {
                option += $"&end_time={endTime}";
            }
            if (from != null)
            {
                option += $"&from={from}";
            }
            if (limit != null)
            {
                option += $"&limit={limit}";
            }
            if (!string.IsNullOrEmpty(direct))
            {
                option += $"&direct={direct}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<QueryAlgoOrderHistoryResponse>(url);
        }
    }
}