using System;
using System.Linq;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Infra.Contexts;
using LunaPetShop.Domain.Queries;
using LunaPetShop.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace LunaPetShop.Domain.Infra.Respositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LunaPetShopContext _lunaPetShopContext;
        public UserRepository(LunaPetShopContext lunaPetShopContext)
        {
            _lunaPetShopContext = lunaPetShopContext;
        }
        public void addUser(User user)
        {
            _lunaPetShopContext.users.Add(user);
            _lunaPetShopContext.SaveChanges();
        }

        public void deleteUser(User user)
        {
            _lunaPetShopContext.users.Remove(user);
            _lunaPetShopContext.SaveChanges();
        }

        public User getById(Guid Id)
        {
            return _lunaPetShopContext.users
                                        .AsNoTracking()
                                        .Where(UserQuery.GetUserById(Id))
                                        .FirstOrDefault();
        }

        public void updateUser(User user)
        {
            _lunaPetShopContext.Entry(user).State = EntityState.Modified;
            _lunaPetShopContext.SaveChanges();
        }
    }
}