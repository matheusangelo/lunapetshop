using LunaPetShop.Domain.Tests.Mocks.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunaPetShop.Domain.Tests.Commands
{
    [TestClass]
    public class CommandCreateUserTests
    {
        [TestMethod]
        public void ShouldReturnSuccessWhenSendValidCommand()
        {
            var validCommand = FakeCommandCreateUser.validCommand();
            
            validCommand.Validate();

            Assert.AreEqual(true, validCommand.Valid);

        }

        [TestMethod]
        public void ShouldReturnFalseWhenSendInvalidCommand()
        {
            var validCommand = FakeCommandCreateUser.invalidCommand();
            
            validCommand.Validate();

            Assert.AreEqual(false, validCommand.Valid);

        }

        [TestMethod]
        public void ShouldReturnSuccessWhenSendInvalidEmailCommand()
        {
            var validCommand = FakeCommandCreateUser.InvalidEmailCommand();
            
            validCommand.Validate();

            Assert.AreEqual(false, validCommand.Valid);

        }
    }
}
