using System;

namespace LunaPetShop.Domain.Entities
{
    public class Pet : Entity
    {
        public Pet()
        {
            
        }
        public Pet(string name, double weigth, int age, string sex, string breed, bool castrated, double size, Guid userId)
        {
            Name = name;
            Weigth = weigth;
            Age = age;
            Sex = sex;
            Breed = breed;
            Castrated = castrated;
            Size = size;
            UserId = userId;
        }

        public string Name { get; set; }
        public double Weigth { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Breed { get; set; }
        public bool Castrated { get; set; }
        public double Size { get; set; }
        public Guid UserId { get; set; }

        //relationshipsss
        public User User { get; set; }

    }
}