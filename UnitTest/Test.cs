using AsyncFileManagement;
using AsyncFileManagement.Clients;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        private TestContext _testContextInstance;

        public TestContext TestContextInstance
        {
            get { return _testContextInstance; }
            set { _testContextInstance = value; }
        }

        [TestMethod]
        public void RequestTest()
        {
            var target = new Client();

            target.RequestSet();
        }
    }
}
