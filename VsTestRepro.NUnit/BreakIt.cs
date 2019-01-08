using NUnit.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Tests
{
    public class BreakIt
    {
        [Test]
        public void BreakItRealGood()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            };

            Assert.Pass();
        }
    }
}