using System;

namespace LunaPetShop.Domain.Repository
{
    public interface IUserRepository
    {
        void addUser();
        void deleteUser();
        void updateUser(Guid Id);

    }
}