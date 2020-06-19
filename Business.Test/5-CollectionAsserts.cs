using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestClass]
    public class CollectionAsserts
    {
        private List<string> _clients;

        [TestInitialize]
        public void TestInitialize()
        {
            _clients = new List<string>
            {
                "Ahmet",
                "Aygün"
            };
        }

        [TestMethod]
        public void Items_and_index_must_be_same()
        {
            List<string> clients = new List<string>
            {
                "Ahmet",
                "Aygün"
            };
            CollectionAssert.AreEqual(_clients, clients);
        }

        [TestMethod]
        public void Collection_must_be_different()
        {
            List<string> clients = new List<string> { "Ahmet" };
            CollectionAssert.AreNotEqual(_clients, clients);
        }

        [TestMethod]
        public void Items_must_be_same_index_can_be_different()
        {
            List<string> clients = new List<string>
            {
                "Aygün",
                "Ahmet"
            };
            CollectionAssert.AreEquivalent(_clients, clients);
        }

        [TestMethod]
        public void Items_must_be_different()
        {
            List<string> clients = new List<string> { "Aygün2", "Ahmet" };
            CollectionAssert.AreNotEquivalent(_clients, clients);
        }

        [TestMethod]
        public void All_items_must_be_not_null()
        {
            CollectionAssert.AllItemsAreNotNull(_clients);
        }

        [TestMethod]
        public void All_items_must_be_unique()
        {
            CollectionAssert.AllItemsAreUnique(_clients);
        }

        [TestMethod]
        public void All_items_must_be_same_type()
        {
            ArrayList arrayList = new ArrayList
            {
                "Ali",
                "Veli"
            };
            CollectionAssert.AllItemsAreInstancesOfType(arrayList, typeof(string));
        }

        [TestMethod]
        public void IsSubsetOf_Test()
        {
            List<string> users = new List<string> { "Ahmet","Aygün","Can"};
            List<string> users2 = new List<string> { "Ahmet", "Can" };

            CollectionAssert.IsSubsetOf(_clients, users);//users left join _client where _client.name is not null 
            CollectionAssert.IsNotSubsetOf(_clients, users2);//_users2 inner join _client where users2.name is null and _client.name is null
        }

        [TestMethod]
        public void Contains_Test()
        {
            CollectionAssert.Contains(_clients,"Aygün");
            CollectionAssert.DoesNotContain(_clients, "Can");
        }
    }
}
