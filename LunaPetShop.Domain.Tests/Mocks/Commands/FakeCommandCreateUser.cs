using LunaPetShop.Domain.Commands;

namespace LunaPetShop.Domain.Tests.Mocks.Commands
{
    public static class FakeCommandCreateUser
    {
        public static CommandCreateUser validCommand()
        {
            return new CommandCreateUser("Matheus", "Angelo", "matheus@outlook.com", "102030");
        }

        public static CommandCreateUser invalidCommand()
        {
            return new CommandCreateUser("", "", "", "");
        }
        public static CommandCreateUser InvalidEmailCommand()
        {
            return new CommandCreateUser("Matheus", "Angelo", "matheusoutlookcom", "102030");
        }
    }
}