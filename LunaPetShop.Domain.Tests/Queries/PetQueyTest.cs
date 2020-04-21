using System.Linq;
using LunaPetShop.Domain.Queries;
using LunaPetShop.Domain.Tests.Mocks.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunaPetShop.Domain.Tests.Commands
{
    [TestClass]
    public class PetQueryTest
    {
        [TestMethod]
        public void ShouldReturnSuccessWhenSendValidQuery()
        {
            var result = FakePetQuery.validQuery()
                                      .AsQueryable()
                                      .Where(PetQuery.GetAllByEmail("matheusangelo@hotmail.com"));

            Assert.AreEqual(1, result.Count());

        }

        [TestMethod]
        public void ShouldReturnSuccessWhenSendInvalidQuery()
        {
            var result = FakePetQuery.validQuery()
                                      .AsQueryable()
                                      .Where(PetQuery.GetAllByEmail("mao@hotmail.com"));

            Assert.AreEqual(0, result.Count());

        }
    }
}
