using System.Collections.Generic;

namespace LunaPetShop.Domain.Entities
{
    public class User : Entity
    {

        public User()
        {
            this.Pets = new List<Pet>();
        }
        public string Name { get; private set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; private set; }
        public List<Pet> Pets { get; set; }

    }
}