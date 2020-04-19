using System;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Repository
{
    public interface IUserRepository
    {
        User getById(Guid Id);
        void addUser(User user);
        void deleteUser(User user);
        void updateUser(User user);

    }
}