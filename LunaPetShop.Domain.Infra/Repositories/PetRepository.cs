using System;
using System.Collections.Generic;
using System.Linq;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Infra.Contexts;
using LunaPetShop.Domain.Queries;
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

        public void AddPet(Pet pet)
        {
            _lunaPetShopContext.pets.Add(pet);
            _lunaPetShopContext.SaveChanges();

        }

        public void DeletePet(Pet pet)
        {
            _lunaPetShopContext.pets.Remove(pet);
            _lunaPetShopContext.SaveChanges();
        }

        public List<Pet> GetAllByEmail(string Email)
        {
            return _lunaPetShopContext.pets
                                .AsNoTracking()
                                .Include(p => p.User)
                                .Where(PetQuery.GetAllByEmail(Email))
                                .ToList();
        }

        public Pet GetPetById(Guid Id)
        {
            return _lunaPetShopContext.pets
                                      .Include(x=>x.User)
                                      .ThenInclude(u=>u.Pets)
                                      .Where(PetQuery.GetPetbyId(Id))
                                      .FirstOrDefault();
        }

        public List<Pet> GetPetByUserId(Guid Id)
        {
            return _lunaPetShopContext.pets
                                      .AsNoTracking()
                                      .Where(PetQuery.GetAllByUserId(Id))
                                      .ToList();
        }

        public void UpdatePet(Pet pet)
        {
            _lunaPetShopContext.Entry(pet).State = EntityState.Modified;
            _lunaPetShopContext.SaveChanges();
        }
    }
}