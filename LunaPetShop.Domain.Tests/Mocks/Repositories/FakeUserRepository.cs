using System;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Tests.Mocks.Respositories
{
    public class FakeUserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}