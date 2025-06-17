using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Request.Copytrading
{
    public class CopytradingTraderPlaceOrderRequest
    {
        [JsonProperty("contract_code")] 
        public string ContractCode { get; set; }
    
        [JsonProperty("price")] 
        public string Price { get; set; }
    
        [JsonProperty("amount")] 
        public string Amount { get; set; }
    
        [JsonProperty("margin_mode")] 
        public string MarginMode { get; set; }
    
        [JsonProperty("order_price_type")] 
        public int OrderPriceType { get; set; }
    
        [JsonProperty("order_direction")] 
        public int OrderDirection { get; set; }
    
        [JsonProperty("lever")] 
        public int Lever { get; set; }
    
        [JsonProperty("tp_trigger_price")] 
        public string TpTriggerPrice { get; set; }
    
        [JsonProperty("sl_trigger_price")] 
        public string SlTriggerPrice { get; set; }
    }
}