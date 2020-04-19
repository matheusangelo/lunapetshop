using System;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Repository
{
    public interface IUserRepository
    {
        User GetById(Guid Id);
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);

    }
}