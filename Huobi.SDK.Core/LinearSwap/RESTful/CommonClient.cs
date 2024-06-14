using System.Threading.Tasks;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Common;
using Huobi.SDK.Core.RequestBuilder;

namespace Huobi.SDK.Core.LinearSwap.RESTful
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
        ///  【通用】获取强平订单(新)
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="pair"></param>
        /// <param name="tradeType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="direct"></param>
        /// <param name="fromId"></param>
        /// <returns></returns>
        public async Task<GetSwapLiquidationOrdersResponse> GetSwapLiquidationOrdersAsync(string contract = null,
            string pair = null, int? tradeType = null, long? startTime = null, long? endTime = null,
            string direct = null, long? fromId = null)
        {
            // location
            string location = "/linear-swap-api/v3/swap_liquidation_orders";

            // option
            string option = null;
            if (contract != null)
            {
                option += $"&contract={contract}";
            }
            if (pair != null)
            {
                option += $"&pair={pair}";
            }
            if (tradeType != null)
            {
                option += $"&trade_type={tradeType}";
            }
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
            return await HttpRequest.GetAsync<GetSwapLiquidationOrdersResponse>(url);
        }

        /// <summary>
        ///  【全仓】获取平台阶梯保证金
        /// </summary>
        /// <param name="contractCode"></param>
        /// <param name="pair"></param>
        /// <param name="contractType"></param>
        /// <param name="businessType"></param>
        /// <returns></returns>
        public async Task<GetSwapCrossLadderMarginResponse> GetSwapCrossLadderMarginAsync(string contractCode = null,
            string pair = null, string contractType = null, string businessType = null)
        {
            // location
            string location = "/linear-swap-api/v1/swap_cross_ladder_margin";

            // option
            string option = null;
            if (contractCode != null)
            {
                option += $"&contract_code={contractCode}";
            }
            if (pair != null)
            {
                option += $"&pair={pair}";
            }
            if (contractType != null)
            {
                option += $"&contract_type={contractType}";
            }
            if (businessType != null)
            {
                option += $"&business_type={businessType}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<GetSwapCrossLadderMarginResponse>(url);
        }
        
        /// <summary>
        ///  【通用】合约要素
        /// </summary>
        /// <param name="contractCode"></param>
        /// <returns></returns>
        public async Task<GetSwapQueryElementsResponse> GetSwapQueryElementsAsync(string contractCode = null)
        {
            // location
            string location = "/linear-swap-api/v1/swap_query_elements";

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
            return await HttpRequest.GetAsync<GetSwapQueryElementsResponse>(url);
        }
        
        /// <summary>
        ///  【通用】获取当前系统时间戳
        /// </summary>
        /// <param name="contractCode"></param>
        /// <returns></returns>
        public async Task<GetTimestampResponse> GetTimestampAsync(string contractCode = null)
        {
            // location
            string location = "/api/v1/timestamp";

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
            return await HttpRequest.GetAsync<GetTimestampResponse>(url);
        }
        
        /// <summary>
        ///  【通用】停服维护
        /// </summary>
        /// <param name="contractCode"></param>
        /// <returns></returns>
        public async Task<GetHeartbeatResponse> GetHeartbeatAsync()
        {
            // location
            string location = "/heartbeat/";

            string url = _urlBuilder.Build(location);
            return await HttpRequest.GetAsync<GetHeartbeatResponse>(url);
        }
    }
}
