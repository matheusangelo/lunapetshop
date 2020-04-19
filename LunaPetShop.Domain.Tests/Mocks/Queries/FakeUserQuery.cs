using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Tests.Mocks.Queries
{
    public static class FakeUserQuery
    {
        public static User validQuery()
        {
            return new User("Matheus","Angelo","matheusangelo@hotmail.com","102030");
        }

        public static User invalidQuery()
        {
            return new User("Matheus","Angelo","matheus@hotmail.com","102030");

        }
    }
}