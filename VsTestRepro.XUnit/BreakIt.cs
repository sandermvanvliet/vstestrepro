using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Xunit;

namespace VsTestRepro.XUnit
{
    public class BreakIt
    {
        [Fact]
        public void BreakItRealGood()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };

            Assert.False(true);
        }
    }
}
