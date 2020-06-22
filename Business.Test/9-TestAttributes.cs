using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class TestAttributes
    {
        [TestMethod]
        [Owner("Ahmet Faruk")]
        [TestCategory("Tester")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void Test1()
        {

        }
        [TestMethod]
        [Owner("Aygün")]
        [TestCategory("Tester")]
        [TestProperty("Updated","Ahmet Faruk")]
        [Priority(2)]
        public void Test2()
        {

        }

        [TestMethod,Ignore]
        public void Ignore()
        {
        }
        [TestMethod,Timeout(100)]
        public void Timeout()
        {
            System.Threading.Thread.Sleep(100);
        }
        [TestMethod,Description("buraya metoda dair detayın açıklamaları girilebilir")]
        public void Description()
        {

        }  
    }
}
