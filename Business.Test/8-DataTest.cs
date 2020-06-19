using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using System.Data.SqlClient;

namespace Business.Test
{
    [TestClass]
    public class DataTest
    {
        public TestContext TestContext { get; set; }
        SqlConnection connection;

        [TestInitialize]
        public void TestInitialize()
        {
            //TestContext.TestName== "DataTestSql"
            //create temp db
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //TestContext.TestName== "DataTestSql"
            //close connection
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"Properties\Users.xml", @"User",DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTestXml()
        {
            DataManager userManager = new DataManager();

            string name = TestContext.DataRow["name"].ToString();
            string tel = TestContext.DataRow["tel"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            bool result=userManager.AddUser(name, tel, email);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DataTestSql()
        {

        }
    }
}
