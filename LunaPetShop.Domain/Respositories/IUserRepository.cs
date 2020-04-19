using System;

namespace LunaPetShop.Domain.Repository
{
    public interface IUserRepository
    {
        void getById(Guid Id);
        void addUser();
        void deleteUser();
        void updateUser(Guid Id);

    }
}