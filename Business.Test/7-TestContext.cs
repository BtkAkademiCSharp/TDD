using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class Test_Context
    {
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("\nTest yükleniyor");
            TestContext.Properties["AddInfo"] = "Bilgi mesajı";
            TestContext.WriteLine("Test Durumu : {0}", TestContext.CurrentTestOutcome);

        }
        [TestCleanup]
        public void TestCleanUp()
        {
            TestContext.WriteLine("\nTest bitti");
            TestContext.WriteLine("Test Durumu : {0}", TestContext.CurrentTestOutcome);
            if(TestContext.CurrentTestOutcome==UnitTestOutcome.Failed)
            {
                //Loglama işlemi yapılabilir 
            }
        }

        [TestMethod]
        public void TestMethod()
        {
            TestContext.WriteLine("\nTestmetodu çalıştı");
            TestContext.WriteLine("Test Adı : {0}",TestContext.TestName);
            TestContext.WriteLine("Test Durumu : {0}",TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sınıfı : {0}",TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Ekstra bilgi : {0}", TestContext.Properties["AddInfo"]);
        }
    }
}
