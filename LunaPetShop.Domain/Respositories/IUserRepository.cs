using System;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Repository
{
    public interface IUserRepository
    {
        User GetById(Guid Id);
        User GetByEmail(string Email);
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);

    }
}