using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;

namespace ProjectText
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string mongodb = string.Format($"mongodb://tangjinghui:900530tjh@cluster0-shard-00-00-9tkft.mongodb.net:27017");
            var client = new MongoClient(mongodb);

        }
    }
}
