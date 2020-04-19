using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Handlers;
using LunaPetShop.Domain.Tests.Mocks.Commands;
using LunaPetShop.Domain.Tests.Mocks.Respositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunaPetShop.Domain.Tests.Commands
{
    [TestClass]
    public class HandlerCreateUserTest
    {
        [TestMethod]
        public void ShouldReturnSuccessWhenSendAValidCommand()
        {
            var handler = new CreateUserHandler(new FakeUserRepository());
            var result = (CommandResult)handler.handle(FakeCommandCreateUser.validCommand());

            Assert.AreEqual(true, result.Success);

        }

        [TestMethod]
        public void ShouldReturnSuccessWhenSendAInvalidCommand()
        {
            var handler = new CreateUserHandler(new FakeUserRepository());
            var result = (CommandResult)handler.handle(FakeCommandCreateUser.invalidCommand());

            Assert.AreEqual(false, result.Success);

        }

    }
}
