using System;
using System.Linq.Expressions;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Queries
{
    public static class PetQuery
    {
        public static Expression<Func<Pet, bool>> GetAllByEmail(string Email)
        {
            return x => x.User.Email == Email;
        }

        public static Expression<Func<Pet, bool>> GetAllByUserId(Guid UserId)
        {
          return x => x.UserId == UserId;
        }
        public static Expression<Func<Pet, bool>> GetPetbyId(Guid Id)
        {
            return x => x.Id == Id;
        }
    }
}