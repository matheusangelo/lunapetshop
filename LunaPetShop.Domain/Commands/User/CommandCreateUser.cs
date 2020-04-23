using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Commands
{
    public class CommandCreateUser : Notifiable, ICommand
    {
        public CommandCreateUser()
        {
            
        }
        public CommandCreateUser(string name, string surName, string email, string password)
        {
            Name = name;
            SurName = surName;
            Email = email;
            Password = password;
            // Pets = new List<Pet>();
        }

        public string Name { get;  set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get;  set; }
        // public List<Pet> Pets { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .HasMinLen(Name, 3, "Name", "Name should have at least 3 chars")
                .HasMinLen(SurName, 3, "Name", "Name should have at least 3 chars")
                .IsEmailOrEmpty(Email,"Email","Invalid Email")
            );
        }
    }
}