using System.Threading.Tasks;
using Huobi.SDK.Core.RequestBuilder;
using Newtonsoft.Json;
using System;
using Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading; 
using Huobi.SDK.Core.LinearSwap.RESTful.Response.Copytrading;

namespace Huobi.SDK.Core.LinearSwap.RESTful
{
    public class CopytradingClient
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
        public CopytradingClient(string accessKey, string secretKey, string host = Host.FUTURES)
        {
            _urlBuilder = new PrivateUrlBuilder(accessKey, secretKey, host);
        }
        
        public async Task<CopytradingTraderPlaceOrderResponse> CopytradingTraderPlaceOrder(CopytradingTraderPlaceOrderRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/place_order");

            return await HttpRequest.PostAsync<CopytradingTraderPlaceOrderResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderQueryContractLeverResponse> CopytradingTraderQueryContractLever(string contractCode, string marginMode)
        {
            // location
            string location = $"/copytrading/trader/query_contract_lever";

            // option
            string option = null;
            if (contractCode != null)
            {
                option += $"&contract_code={contractCode}";
            }
            if (marginMode != null)
            {
                option += $"&margin_mode={marginMode}";
            }
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderQueryContractLeverResponse>(url);
        }
        
        public async Task<CopytradingTraderUpdatedContractLeverResponse> CopytradingTraderUpdatedContractLever(CopytradingTraderUpdatedContractLeverRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/updated_contract_lever");

            return await HttpRequest.PostAsync<CopytradingTraderUpdatedContractLeverResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderCloseOrderResponse> CopytradingTraderCloseOrder(CopytradingTraderCloseOrderRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/close_order");

            return await HttpRequest.PostAsync<CopytradingTraderCloseOrderResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderCloseAllPositionResponse> CopytradingTraderCloseAllPosition(CopytradingTraderCloseAllPositionRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/close_all_position");

            return await HttpRequest.PostAsync<CopytradingTraderCloseAllPositionResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderAddMarginResponse> CopytradingTraderAddMargin(CopytradingTraderAddMarginRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/add_margin");

            return await HttpRequest.PostAsync<CopytradingTraderAddMarginResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderPositionListResponse> CopytradingTraderPositionList()
        {
            // location
            string location = $"/copytrading/trader/position_list";
            // option
            string option = null;
            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderPositionListResponse>(url);
        }
        
        public async Task<CopytradingTraderAccountTransferResponse> CopytradingTraderAccountTransfer(CopytradingTraderAccountTransferRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/account_transfer");

            return await HttpRequest.PostAsync<CopytradingTraderAccountTransferResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderCurrentPositionsResponse> CopytradingTraderCurrentPositions(CopytradingTraderCurrentPositionsRequest request)
        {
            // location
            string location = $"/copytrading/trader/current_positions";

            // option
            string option = null;
            if (request.ContractCode != null)
            {
                option += $"&contract_code={request.ContractCode}";
            }
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.EndTime != null)
            {
                option += $"&end_time={request.EndTime}";
            }
            if (request.Direct != null)
            {
                option += $"&direct={request.Direct}";
            }
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.FromId != null)
            {
                option += $"&from_id={request.FromId}";
            }
            if (request.Limit != null)
            {
                option += $"&limit={request.Limit}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderCurrentPositionsResponse>(url);
        }
        
        public async Task<CopytradingTraderPositionPositionsResponse> CopytradingTraderPositionPositions(CopytradingTraderCurrentPositionsRequest request)
        {
            // location
            string location = $"/copytrading/trader/position_positions";

            // option
            string option = null;
            if (request.ContractCode != null)
            {
                option += $"&contract_code={request.ContractCode}";
            }
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.EndTime != null)
            {
                option += $"&end_time={request.EndTime}";
            }
            if (request.Direct != null)
            {
                option += $"&direct={request.Direct}";
            }
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.FromId != null)
            {
                option += $"&from_id={request.FromId}";
            }
            if (request.Limit != null)
            {
                option += $"&limit={request.Limit}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderPositionPositionsResponse>(url);
        }
        
        public async Task<CopytradingTraderTpslOrderResponse> CopytradingTraderTpslOrder(CopytradingTraderTpslOrderResponseRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/tpsl_order");

            return await HttpRequest.PostAsync<CopytradingTraderTpslOrderResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderQueryContractResponse> CopytradingTraderQueryContract()
        {
            // location
            string location = $"/copytrading/trader/query_contract";
            // option
            string option = null;
            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderQueryContractResponse>(url);
        }
        
        public async Task<CopytradingTraderOrderTotalDetailResponse> CopytradingTraderOrderTotalDetail()
        {
            // location
            string location = $"/copytrading/trader/order_total_detail";
            // option
            string option = null;
            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderOrderTotalDetailResponse>(url);
        }
        
        public async Task<CopytradingTraderProfitHistoryDetailsResponse> CopytradingTraderProfitHistoryDetails(CopytradingTraderProfitHistoryDetailsRequest request)
        {
            // location
            string location = $"/copytrading/trader/profit_history_details";

            // option
            string option = null;
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.EndTime != null)
            {
                option += $"&end_time={request.EndTime}";
            }
            if (request.Direct != null)
            {
                option += $"&direct={request.Direct}";
            }
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.FromId != null)
            {
                option += $"&from_id={request.FromId}";
            }
            if (request.Limit != null)
            {
                option += $"&limit={request.Limit}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderProfitHistoryDetailsResponse>(url);
        }
        
        public async Task<CopytradingTraderTotalProfitHistoryResponse> CopytradingTraderTotalProfitHistory()
        {
            // location
            string location = $"/copytrading/trader/total_profit_history";
            // option
            string option = null;
            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderTotalProfitHistoryResponse>(url);
        }
        
        public async Task<CopytradingTraderQueryFollowersResponse> CopytradingTraderQueryFollowers(CopytradingTraderProfitHistoryDetailsRequest request)
        {
            // location
            string location = $"/copytrading/trader/query_followers";

            // option
            string option = null;
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.EndTime != null)
            {
                option += $"&end_time={request.EndTime}";
            }
            if (request.Direct != null)
            {
                option += $"&direct={request.Direct}";
            }
            if (request.StartTime != null)
            {
                option += $"&start_time={request.StartTime}";
            }
            if (request.FromId != null)
            {
                option += $"&from_id={request.FromId}";
            }
            if (request.Limit != null)
            {
                option += $"&limit={request.Limit}";
            }
            
            if (option != null)
            {
                location += $"?{option.Substring(1)}";
            }

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderQueryFollowersResponse>(url);
        }
        
        public async Task<CopytradingTraderRemoveFollowerResponse> CopytradingTraderRemoveFollower(CopytradingTraderRemoveFollowerRequest request)
        {
            string url = _urlBuilder.Build(POST_METHOD, "/copytrading/trader/remove_follower");

            return await HttpRequest.PostAsync<CopytradingTraderRemoveFollowerResponse>(url, JsonConvert.SerializeObject(request));
        }
        
        public async Task<CopytradingTraderOpenOrdersResponse> CopytradingTraderOpenOrders(string contractCode)
        {
            // location
            string location = $"/copytrading/trader/open_orders";

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

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderOpenOrdersResponse>(url);
        }
        
        public async Task<CopytradingTraderTpslOpenOrdersResponse> CopytradingTraderTpslOpenOrders(string contractCode)
        {
            // location
            string location = $"/copytrading/trader/tpsl_open_orders";

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

            string url = _urlBuilder.Build(GET_METHOD, location);
            return await HttpRequest.GetAsync<CopytradingTraderTpslOpenOrdersResponse>(url);
        }
    }
}