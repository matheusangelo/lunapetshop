using System;
using System.Collections.Generic;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Tests.Mocks.Queries
{
    public static class FakePetQuery
    {

        public static List<Pet> validQuery()
        {
            var pets = new List<Pet>();
          
            var userx = new User("Matheus", "Angelo", "matheusangelo@hotmail.com", "102030");
            var usery = new User("Matheus", "Angelo", "matheus@hotmail.com", "102030");
          
            var pet = new Pet("Luna",10,1,"Woman","Sirium",false,10,Guid.NewGuid(),userx);
            var pet2 = new Pet("Banguela",10,1,"Woman","Sirium",false,10,Guid.NewGuid(),usery);

            pets.Add(pet);
            pets.Add(pet2); 

            return pets;
        }

    }
}