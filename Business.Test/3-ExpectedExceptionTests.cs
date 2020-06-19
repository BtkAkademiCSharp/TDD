using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class ExpectedExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod()
        {
            Business.ExpectedException expectedException = new ExpectedException();
            expectedException.TestRequest(0);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TestMethod2()
        {
            //Testten geçemez çünkü exception hatası bekliyor gelmemesi durumunda test başarısız demektir
            //AllowDerivedTypes true çekerek exception sınıfından türemiş herhangi bir hata sınıfı throw etmesi testi başarılı kılar
        }
    }

}

