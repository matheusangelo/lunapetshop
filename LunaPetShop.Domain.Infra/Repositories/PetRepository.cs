using System;
using System.Collections.Generic;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Infra.Contexts;
using LunaPetShop.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace LunaPetShop.Domain.Infra.Repository
{
    public class PetRepository : IPetRepository
    {

        private readonly LunaPetShopContext _lunaPetShopContext;

        public PetRepository(LunaPetShopContext lunaPetShopContext)
        {
            _lunaPetShopContext = lunaPetShopContext;
        }
        
        public void DeletePet(Pet pet)
        {
            _lunaPetShopContext.Remove(pet);
            _lunaPetShopContext.SaveChanges();
        }

        public List<Pet> GetAllByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public Pet GetPetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetPetByUserId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePet(Pet pet)
        {
            _lunaPetShopContext.Entry(pet).State = EntityState.Modified;
            _lunaPetShopContext.SaveChanges();
        }
    }
}