using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Business;
using System.Linq.Expressions;

namespace Business.Test
{
    [TestClass]
    public class MockUsage
    {
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void Give_error_when_second_time_added_same_product()
        {
            var mock = new Mock<IManagerDal>();
            mock.Setup(t => t.IsExist(It.IsAny<Expression<Func<int,bool>>>())).Returns(true);

            MoqManager moqManager = new MoqManager(mock.Object);

            moqManager.Add(It.IsAny<int>());
        }
    }
}
