using Xunit;
using Microsoft.Extensions.Configuration;
using System;
using Newtonsoft.Json;
using Huobi.SDK.Core.LinearSwap.WS;
using Huobi.SDK.Core.LinearSwap.WS.Response.Notify;

namespace Huobi.SDK.Core.Test.LinearSwap
{
    public class WsUnifiedNotifyTest
    {
        static IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        static WSUnifiedNotifyClient client = new WSUnifiedNotifyClient(config["AccessKey"], config["SecretKey"]);

        /// <summary>
        /// Subscribe to unified-margin order updates.
        /// IMPORTANT: Place a manual order on HTX within the 30-second window to trigger a push.
        /// </summary>
        [Theory]
        [InlineData("*")]
        public void SubOrdersTest(string contractCode)
        {
            bool has_data = false;

            client.SubOrders(contractCode, delegate (SubUnifiedOrdersResponse data)
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                Console.WriteLine(json);
                System.IO.File.AppendAllText("/tmp/ws_unified_orders.log", json + "\n---\n");
                has_data = true;
            });

            System.Threading.Thread.Sleep(1000 * 60);
            Assert.True(has_data);
            client.UnsubOrders(contractCode);
            System.Threading.Thread.Sleep(1000 * 5);
        }
    }
}
