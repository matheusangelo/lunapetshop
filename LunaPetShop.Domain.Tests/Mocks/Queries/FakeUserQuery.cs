using System.Collections.Generic;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Tests.Mocks.Queries
{
    public static class FakeUserQuery
    {
        public static List<User> validQuery()
        {
            var users = new List<User>();

            var valid = new User("Matheus", "Angelo", "matheusangelo@hotmail.com", "102030");
            var invalid = new User("Matheus", "Angelo", "matheus@hotmail.com", "102030");

            users.Add(valid);
            users.Add(invalid);

            return users;
        }

    }
}