using System;
using Huobi.SDK.Core.RequestBuilder;
using Xunit;

namespace Huobi.SDK.Core.Test.RequestBuilder
{
    public class PrivateUrlBuilderTest
    {
        [Fact]
        public void Build_NoRequestParameter_Success()
        {
            var builder = new PrivateUrlBuilder("abcdefg-hijklmn-opqrst-uvwxyz", "12345-67890-12345-67890", "api.huobi.pro","256");
            string result = builder.Build("GET", "/v1/account/accounts");

            string expected = @"https://api.huobi.pro/v1/account/accounts?AccessKeyId=abcdefg-hijklmn-opqrst-uvwxyz&SignatureMethod=HmacSHA256&SignatureVersion=2&Timestamp=2024-10-24T01%3A48%3A53&Signature=vMtLuwZJGfiVNSGaEcP8sRpQ6B%2Fs6iye8baeIZccF6A%3D";
            Assert.Equal(expected, result);
        }
    }
}
