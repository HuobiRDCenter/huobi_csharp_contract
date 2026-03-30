using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Huobi.SDK.Core.LinearSwap.RESTful.Response.CopyTradingTrade;

namespace Huobi.SDK.Core.LinearSwap.RESTful
{
    /// <summary>
    /// 合约跟单 V6 接口
    /// </summary>
    public class CopyTradingTradeClient
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
        public CopyTradingTradeClient(string accessKey, string secretKey, string host = Host.FUTURES)
        {
            _urlBuilder = new PrivateUrlBuilder(accessKey, secretKey, host);
        }

        /// <summary>
        /// 查询交易员带单产品
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeInstrumentResult>> QueryTraderInstrumentsAsync(string instType)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/instruments";
            
            // option
            string option = null;
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeInstrumentResult>>(url);
        }

        /// <summary>
        /// 查询交易员数据统计
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeStatisticsResult>> QueryTraderStatisticsAsync(string instType)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/statistics";
            
            // option
            string option = null;
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeStatisticsResult>>(url);
        }

        /// <summary>
        /// 查询交易员历史分润
        /// </summary>
        /// <param name="instId">产品ID</param>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="after">查询游标，查询该条数据之后的数据</param>
        /// <param name="before">查询游标，查询该条数据之前的数据</param>
        /// <param name="limit">返回数据量，默认为100</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeProfitSharingHistoryResult>> QueryTraderProfitSharingHistoryAsync(
            string instId = null, string instType = null, long? begin = null, long? end = null, 
            long? after = null, long? before = null, int? limit = null)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/profit-sharing-history";
            
            // option
            string option = null;
            if (instId != null)
            {
                option += $"&instId={instId}";
            }
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (begin != null)
            {
                option += $"&begin={begin}";
            }
            if (end != null)
            {
                option += $"&end={end}";
            }
            if (after != null)
            {
                option += $"&after={after}";
            }
            if (before != null)
            {
                option += $"&before={before}";
            }
            if (limit != null)
            {
                option += $"&limit={limit}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeProfitSharingHistoryResult>>(url);
        }

        /// <summary>
        /// 查询交易员历史分润汇总
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeProfitSharingHistorySummaryResult>> QueryTraderProfitSharingHistorySummaryAsync(string instType)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/profit-sharing-history-summary";
            
            // option
            string option = null;
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeProfitSharingHistorySummaryResult>>(url);
        }

        /// <summary>
        /// 查询交易员待分润汇总
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <param name="ccy">分润币种</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeUnrealizedProfitSharingSummaryResult>> QueryTraderUnrealizedProfitSharingSummaryAsync(
            string instType, string ccy)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/unrealized-profit-sharing-summary";
            
            // option
            string option = null;
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (ccy != null)
            {
                option += $"&ccy={ccy}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeUnrealizedProfitSharingSummaryResult>>(url);
        }

        /// <summary>
        /// 查询交易员的跟随者列表
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <param name="begin">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="after">查询游标，查询该条数据之后的数据</param>
        /// <param name="before">查询游标，查询该条数据之前的数据</param>
        /// <param name="limit">返回数据量，默认为100</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeFollowersResult>> QueryTraderFollowersAsync(
            string instType, long? begin = null, long? end = null, 
            long? after = null, long? before = null, int? limit = null)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/followers";
            
            // option
            string option = null;
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (begin != null)
            {
                option += $"&begin={begin}";
            }
            if (end != null)
            {
                option += $"&end={end}";
            }
            if (after != null)
            {
                option += $"&after={after}";
            }
            if (before != null)
            {
                option += $"&before={before}";
            }
            if (limit != null)
            {
                option += $"&limit={limit}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeFollowersResult>>(url);
        }

        /// <summary>
        /// 交易员移除跟随者
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <param name="followerUids">跟随者用户ID列表，多个ID用逗号分隔，最多10个</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeDeleteFollowerResult>> DeleteTraderFollowerAsync(string instType, string followerUids)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/api/v6/copyTrading/trader/follower");

            // content
            string content = null;
            if (instType != null)
            {
                content += $",\"instType\": \"{instType}\"";
            }
            if (followerUids != null)
            {
                content += $",\"followerUids\": \"{followerUids}\"";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeDeleteFollowerResult>>(url, content);
        }

        /// <summary>
        /// 交易员资金划转
        /// </summary>
        /// <param name="amt">划转金额</param>
        /// <param name="from">转出账户 6:带单保证金账户</param>
        /// <param name="to">转入账户 6:带单保证金账户</param>
        /// <param name="ccy">币种</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeTransferResult>> TraderTransferAsync(string amt, string from, string to, string ccy)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/api/v6/copyTrading/trader/transfer");

            // content
            string content = null;
            if (amt != null)
            {
                content += $",\"amt\": \"{amt}\"";
            }
            if (from != null)
            {
                content += $",\"from\": \"{from}\"";
            }
            if (to != null)
            {
                content += $",\"to\": \"{to}\"";
            }
            if (ccy != null)
            {
                content += $",\"ccy\": \"{ccy}\"";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeTransferResult>>(url, content);
        }

        /// <summary>
        /// 交易员设置跟单配置
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <param name="enable">开启或关闭跟单 true 开启 false 关闭</param>
        /// <param name="profitSharingRatio">分润比例</param>
        /// <param name="maxFollowers">跟单人数上限</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeFollowerSettingsResult>> TraderFollowerSettingsAsync(
            string instType, bool? enable = null, string profitSharingRatio = null, string maxFollowers = null)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/api/v6/copyTrading/trader/follower-settings");

            // content
            string content = null;
            if (instType != null)
            {
                content += $",\"instType\": \"{instType}\"";
            }
            if (enable != null)
            {
                content += $",\"enable\": {(enable.Value ? "true" : "false")}";
            }
            if (profitSharingRatio != null)
            {
                content += $",\"profitSharingRatio\": \"{profitSharingRatio}\"";
            }
            if (maxFollowers != null)
            {
                content += $",\"maxFollowers\": \"{maxFollowers}\"";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeFollowerSettingsResult>>(url, content);
        }

        /// <summary>
        /// 查询交易员配置
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeConfigResult>> TraderConfigAsync(string instType)
        {
            // ulr
            string location = "/api/v6/copyTrading/trader/config";
            
            // option
            string option = null;
            if (instType != null)
            {
                option += $"&instType={instType}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeConfigResult>>(url);
        }

        /// <summary>
        /// 生成带单APIKEY
        /// </summary>
        /// <param name="instType">产品类型 PERP 永续合约</param>
        /// <returns></returns>
        public async Task<CopyTradingTradeBaseArrayResult<CopyTradingTradeApikeyResult>> TraderApikeyAsync(string instType)
        {
            // ulr
            string url = _urlBuilder.Build(POST_METHOD, "/api/v6/copyTrading/trader/apikey");

            // content
            string content = null;
            if (instType != null)
            {
                content += $",\"instType\": \"{instType}\"";
            }
            if (content != null)
            {
                content = $"{{ {content.Substring(1)} }}";
            }
            return await HttpRequest.PostAsync<CopyTradingTradeBaseArrayResult<CopyTradingTradeApikeyResult>>(url, content);
        }
    }
}