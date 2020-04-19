using System.Linq;
using LunaPetShop.Domain.Queries;
using LunaPetShop.Domain.Tests.Mocks.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunaPetShop.Domain.Tests.Commands
{
    [TestClass]
    public class UserQueryTest
    {
        [TestMethod]
        public void ShouldReturnSuccessWhenSendValidQuery()
        {
            var result = FakeUserQuery.validQuery()
                                      .AsQueryable()
                                      .Where(UserQuery.GetUserByEmail("matheusangelo@hotmail.com"));

            Assert.AreEqual(1, result.Count());

        }

        [TestMethod]
        public void ShouldReturnSuccessWhenSendInvalidQuery()
        {
            var result = FakeUserQuery.validQuery()
                                      .AsQueryable()
                                      .Where(UserQuery.GetUserByEmail("mao@hotmail.com"));

            Assert.AreEqual(0, result.Count());

        }
    }
}
