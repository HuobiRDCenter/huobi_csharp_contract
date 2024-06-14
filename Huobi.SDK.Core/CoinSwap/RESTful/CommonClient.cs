using System.Threading.Tasks;
using Huobi.SDK.Core.CoinSwap.RESTful.Response.Common;
using Huobi.SDK.Core.RequestBuilder;

namespace Huobi.SDK.Core.CoinSwap.RESTful
{
    /// <summary>
    /// Responsible to get market information
    /// </summary>
    public class CommonClient
    {
        private PublicUrlBuilder _urlBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host">the host that the client connects to</param>
        public CommonClient(string host = Host.FUTURES)
        {
            _urlBuilder = new PublicUrlBuilder(host);
        }

        /// <summary>
        ///  获取强平订单(新)
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="tradeType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="direct"></param>
        /// <param name="fromId"></param>
        /// <returns></returns>
        public async Task<SwapLiquidationOrdersResponse> SwapLiquidationOrdersAsync(string contract,
            int tradeType, long? startTime = null, long? endTime = null,
            string direct = null, long? fromId = null)
        {
            // location
            string location = "/swap-api/v3/swap_liquidation_orders";

            // option
            string option = null;
            option += $"&contract={contract}";
            option += $"&trade_type={tradeType}";
            if (startTime != null)
            {
                option += $"&start_time={startTime}";
            }
            if (endTime != null)
            {
                option += $"&end_time={endTime}";
            }
            if (direct != null)
            {
                option += $"&direct={direct}";
            }
            if (fromId != null)
            {
                option += $"&from_id={fromId}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<SwapLiquidationOrdersResponse>(url);
        }
        
        /// <summary>
        ///  合约要素
        /// </summary>
        /// <param name="contractCode"></param>
        /// <returns></returns>
        public async Task<SwapQueryElementsResponse> SwapQueryElementsAsync(string contractCode = null)
        {
            // location
            string location = "/swap-api/v1/swap_query_elements";

            // option
            string option = null;
            if (contractCode != null)
            {
                option += $"&contract_code={contractCode}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<SwapQueryElementsResponse>(url);
        }
        
        /// <summary>
        ///  获取当前系统时间戳
        /// </summary>
        /// <returns></returns>
        public async Task<TimestampResponse> TimestampAsync()
        {
            // location
            string location = "/api/v1/timestamp";

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<TimestampResponse>(url);
        }
        
        /// <summary>
        ///  查询系统是否可用
        /// </summary>
        /// <returns></returns>
        public async Task<HeartbeatResponse> HeartbeatAsync()
        {
            // location
            string location = "/heartbeat/";

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<HeartbeatResponse>(url);
        }
        
        /// <summary>
        ///  获取当前系统状态
        /// </summary>
        /// <returns></returns>
        public async Task<SummaryResponse> SummaryAsync()
        {
            // location
            string location = "/api/v2/summary.json";

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<SummaryResponse>(url);
        }
    }
}
