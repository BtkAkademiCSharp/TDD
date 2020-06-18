using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void TrimLeftAndRightEmptySpaces()
        {
            //Arrange (Hazırlık)
            string expression = "   Ahmet Faruk ULU  ";
            string expected = "Ahmet Faruk ULU";

            //Act (Testi başlat)
            string result = StringHelper.DeleteEmptySpace(expression);

            //Assert (Kontrol)
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TrimAllEmptySpaces()
        {
            //Arrange (Hazırlık)
            string expression = "Ahmet    Faruk   ULU";
            string expected = "Ahmet Faruk ULU";

            //Act (Testi başlat)
            string result = StringHelper.DeleteEmptySpace(expression);

            //Assert (Kontrol)
            Assert.AreEqual(expected, result);
        }
    }
}
