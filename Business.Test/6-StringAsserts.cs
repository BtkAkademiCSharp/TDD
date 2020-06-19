using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class StringAsserts
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Ahmet Faruk Ulu", "ruk");
        }

        [TestMethod]
        public void StringMatches()
        {
            StringAssert.Matches("Ahmet Faruk ULU", new Regex("[a-zA-Z]"));
            StringAssert.DoesNotMatch("Ahmet Faruk ULU", new Regex("[0-9]"));
        }

        [TestMethod]
        public void StartsWith()
        {
            StringAssert.StartsWith("Ahmet Faruk ULU", "Ahm");
        }

        [TestMethod]
        public void EndsWith()
        {
            StringAssert.EndsWith("Ahmet Faruk ULU", "LU");
        }
    }
}
