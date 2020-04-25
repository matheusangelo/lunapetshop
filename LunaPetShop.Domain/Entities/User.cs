using System.Collections.Generic;

namespace LunaPetShop.Domain.Entities
{
    public class User : Entity
    {

        public User()
        {
            this.Pets = new HashSet<Pet>();
        }

        public User(string name, string surName, string email, string password)
        {
            Name = name;
            SurName = surName;
            Email = email;
            Password = password;
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Pet> Pets { get; set; }

    }
}