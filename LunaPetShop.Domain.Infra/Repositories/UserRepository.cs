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
        public void AddUser(User user)
        {
            _lunaPetShopContext.users.Add(user);
            _lunaPetShopContext.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _lunaPetShopContext.users.Remove(user);
            _lunaPetShopContext.SaveChanges();
        }

        public User GetByEmail(string Email)
        {
            return _lunaPetShopContext.users
                                      .AsNoTracking()
                                      .Where(UserQuery.GetUserByEmail(Email))
                                      .FirstOrDefault();
        }

        public User GetById(Guid Id)
        {
            return _lunaPetShopContext.users
                                      .AsNoTracking()
                                      .Where(x=>x.Id == Id)
                                      .FirstOrDefault();
                                      
        }

        public void UpdateUser(User user)
        {
            _lunaPetShopContext.Entry(user).State = EntityState.Modified;
            _lunaPetShopContext.SaveChanges();
        }
    }
}