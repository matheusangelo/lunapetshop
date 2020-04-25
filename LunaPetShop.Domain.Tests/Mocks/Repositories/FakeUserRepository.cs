using System;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Tests.Mocks.Respositories
{
    public class FakeUserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
        }

        public void DeleteUser(User user)
        {
        }

        public User GetByEmail(string Email)
        {
            return new User("","","","");
        }

        public User GetById(Guid Id)
        {
            return new User("","","","");
        }

        public void UpdateUser(User user)
        {
        }
    }
}