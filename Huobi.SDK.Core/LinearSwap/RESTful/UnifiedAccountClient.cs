using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.UnifiedAccount;

namespace Huobi.SDK.Core.LinearSwap.RESTful
{
    /// <summary>
    /// Responsible to operate account
    /// </summary>
    public class UnifiedAccountClient
    {
        private const string GET_METHOD = "GET";
        private const string POST_METHOD = "POST";

        private readonly PrivateUrlBuilder _urlBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="host">the host that the client connects to</param>
        public UnifiedAccountClient(string accessKey, string secretKey, string host = Host.FUTURES)
        {
            _urlBuilder = new PrivateUrlBuilder(accessKey, secretKey, host);
        }

        /// <summary>
        /// U本位合约账户类型查询接口
        /// </summary>
        /// <returns></returns>
        public async Task<GetSwapUnifiedAccountTypeResponse> GetSwapUnifiedAccountTypeAsync()
        {
            // ulr
            string url = _urlBuilder.Build(GET_METHOD, "/linear-swap-api/v3/swap_unified_account_type");

            // content is null
            return await HttpRequest.GetAsync<GetSwapUnifiedAccountTypeResponse>(url);
        }
        
        /// <summary>
        /// 账户类型更改
        /// </summary>
        /// <param name="accountType"></param>
        /// <returns></returns>
        public async Task<GetSwapUnifiedAccountTypeResponse> SwapSwitchAccountTypeAsync(int? accountType = null)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/linear-swap-api/v3/swap_switch_account_type");

            // content
            string content = null;
            if (accountType != null)
            {
                content += $",\"accountType\": {accountType}";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<GetSwapUnifiedAccountTypeResponse>(url, content);
        }
        
        /// <summary>
        /// 查询统一账户资产
        /// </summary>
        /// <param name="contractCode"></param>
        /// <returns></returns>
        public async Task<UnifiedAccountInfoResponse> UnifiedAccountInfoAsync(string contractCode = null)
        {
            // ulr
            string location = _urlBuilder.Build(GET_METHOD, "/linear-swap-api/v3/unified_account_info");
            
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

            string url = _urlBuilder.Build(GET_METHOD,location);

            // content is null
            return await HttpRequest.GetAsync<UnifiedAccountInfoResponse>(url);
        }
        
        /// <summary>
        /// 可抵扣资产查询
        /// </summary>
        /// <param name="tradePartition"></param>
        /// <returns></returns>
        public async Task<LinearSwapOverviewAccountInfoResponse> LinearSwapOverviewAccountInfoAsync(string tradePartition = null)
        {
            // ulr
            string location = _urlBuilder.Build(GET_METHOD, "/linear-swap-api/v3/linear_swap_overview_account_info");
            
            // option
            string option = null;
            if (tradePartition != null)
            {
                option += $"&trade_partition={tradePartition}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD,location);

            // content is null
            return await HttpRequest.GetAsync<LinearSwapOverviewAccountInfoResponse>(url);
        }
        
        /// <summary>
        /// 设置U本位合约手续费抵扣方式
        /// </summary>
        /// <param name="feeOption"></param>
        /// <param name="deductionCurrency"></param>
        /// <returns></returns>
        public async Task<LinearSwapFeeSwitchResponse> LinearSwapFeeSwitchAsync(int feeOption, string deductionCurrency)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/linear-swap-api/v3/linear_swap_fee_switch");

            // content
            string content = null;
            content += $",\"fee_option\": {feeOption}";
            if (deductionCurrency != null)
            {
                content += $",\"deduction_currency\": \"{deductionCurrency}\"";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<LinearSwapFeeSwitchResponse>(url, content);
        }
        
        /// <summary>
        /// 调整逐仓持仓保证金
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="asset"></param>
        /// <param name="contractCode"></param>
        /// <param name="type"></param>
        /// <param name="direction"></param>
        /// <param name="clientOrderId"></param>
        /// <returns></returns>
        public async Task<FixPositionMarginChangeResponse> FixPositionMarginChangeAsync(double amount, string asset,
            string contractCode, int type, int direction, long? clientOrderId= null)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/linear-swap-api/v3/fix_position_margin_change");

            // content
            string content = null;
            content += $",\"amount\": {amount}";
            content += $",\"asset\": \"{asset}\"";
            content += $",\"contract_code\": \"{contractCode}\"";
            content += $",\"type\": {type}";
            content += $",\"direction\": {direction}";
            if (clientOrderId != null)
            {
                content += $",\"clientOrderId\": {clientOrderId}";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<FixPositionMarginChangeResponse>(url, content);
        }
        
        /// <summary>
        /// 查询调整逐仓持仓保证金记录
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="contractCode"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="direct"></param>
        /// <param name="fromId"></param>
        /// <returns></returns>
        public async Task<FixPositionMarginChangeRecordResponse> FixPositionMarginChangeRecordAsync(string asset,
            string contractCode, long? startTime = null, long? endTime = null, string direct = null,
            long? fromId = null)
        {
            // ulr
            string location = _urlBuilder.Build(GET_METHOD, "/linear-swap-api/v3/fix_position_margin_change_record");
            
            // option
            string option = null;
            if (asset != null)
            {
                option += $"&asset={asset}";
            }
            if (contractCode != null)
            {
                option += $"&contract_code={contractCode}";
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

            string url = _urlBuilder.Build(GET_METHOD,location);
            return await HttpRequest.GetAsync<FixPositionMarginChangeRecordResponse>(url);
        }
    }
}


