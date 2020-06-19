using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class AssemblyTests
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("------------------------------Running asssembly initialize------------------------------");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("------------------------------Running asssembly cleanup------------------------------");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("------------------------------Running testmethod1------------------------------");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("------------------------------Running testmethod2------------------------------");
        }
    }
    [TestClass]
    public class AssemblyTests2
    {
        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("------------------------------Running testmethod3------------------------------");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Debug.WriteLine("------------------------------Running testmethod4------------------------------");
        }
    }
}
