using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class Asserts
    {
        [TestMethod]
        public void CustomMessageAssert()
        {
            double number=16;
            double expected = 4;
            double result = Math.Sqrt(number)+1;

            Assert.AreEqual(expected, result, "{0} sayısının karekökü {1} olmalıdır bir yerlerde sorun var",number,expected);
        }
        [TestMethod]
        public void Delta()
        {
            double s1 = 3.1234;
            double expected = 3.12345678;

            double delta = 0.0001;//hata payı virgülden sonraki 4 hanenin aynı olması testi doğrulamaya yetiyor

            //Assert.AreEqual(expected, s1); //hata verir
            Assert.AreEqual(expected, s1,delta);
        }
        [TestMethod]
        public void IgnoreCase()
        {
            string message = "MESAJ";
            string expected = "mesaj";

            Assert.AreEqual(expected, message,true);
        }
        [TestMethod]
        public void AreNotEqual()
        {
            int notExpected = 0;
            int result = 1;

            Assert.AreNotEqual(notExpected, result);
        }
        [TestMethod]
        public void AreSame()
        {
            int[] numbers = new int[] { 1, 2, 3 };
            int[] otherNumbers = numbers;//aynı referansa sahip oldukları için test başarılı olur

            numbers[0] = 10;

            Assert.AreSame(numbers, otherNumbers);
        }
        [TestMethod]
        public void AreSameWithValueType()
        {
            int s1 = 10;
            int s2 = s1;

            Assert.AreEqual(s1, s2);//true döner değerleri aynıdır
            Assert.AreSame(s1, s2);//false döner ramdeki adresleri farklıdır
            //Assert.AreNotSame(s1, s2); =>diyerek true döndürbiliriz
        }
        [TestMethod]
        public void Inconclusive()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Test başarılı ama yeterli değil farklı komplikasyonlar düşünülerek yeniden test edilmeli");
        }
        [TestMethod]
        public void IsInstance()
        {
            float number = 5;

            Assert.IsInstanceOfType(number, typeof(float));
            Assert.IsNotInstanceOfType(number, typeof(string));
        }
        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }
        [TestMethod]
        public void IsNull()
        {
            string name = null;
            string name2 = string.Empty;

            Assert.IsNull(name);
            Assert.IsNotNull(name2);
        }
        [TestMethod]
        public void Fail()
        {
            bool flag = true;
            if (flag)
                Assert.Fail("Flag true olduğu için test geçersiz");
        }
    }
}
