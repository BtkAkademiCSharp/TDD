using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace Business.Test
{
    [TestClass]
    public class DataTest
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"Properties\Users.xml", @"User", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTestXml()
        {
            DataManager dataManager = new DataManager();
            string name = TestContext.DataRow["name"].ToString();
            string tel = TestContext.DataRow["tel"].ToString();
            string email = TestContext.DataRow["email"].ToString();

            bool result = dataManager.AddUser(name, tel, email);

            Assert.IsTrue(result);
        }

        [DataSource("MyDataSource"), TestMethod]
        [CreateTempTableAttribute]//Geçici tablo oluşturuyoruz
        public void DataTestSql()
        {
            DataManager dataManager = new DataManager();
            int s1 = int.Parse(TestContext.DataRow["s1"].ToString());
            int s2 = int.Parse(TestContext.DataRow["s2"].ToString());
            int result = int.Parse(TestContext.DataRow["result"].ToString());

            int expected = dataManager.Addition(s1, s2);

            Assert.AreEqual(expected, result,"{0}+{1}={2} şeklindeki sonuç yanlış",s1,s2,result);
        }
    }
    public class CreateTempTableAttribute : Attribute
    {
        SqlConnection connection;
        public CreateTempTableAttribute()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDbCon"].ConnectionString);
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(@"IF OBJECT_ID('tempdb..##Numbers') IS NOT NULL DROP TABLE ##Numbers 
            create table ##Numbers(s1 int,s2 int,result int) 
            insert into ##Numbers values(1,1,2),(2,2,4),(3,3,6),(4,4,8)", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        ~CreateTempTableAttribute()
        {
            try
            {
                if(connection!=null)
                {
                    connection.Dispose();
                    connection = null;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
