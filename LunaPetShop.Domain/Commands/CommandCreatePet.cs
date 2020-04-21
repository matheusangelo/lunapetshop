using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Commands
{
    public class CommandCreatePet : Notifiable, ICommand
    {
        public string Name { get; set; }
        public double Weigth { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Breed { get; set; }
        public bool Castrated { get; set; }
        public double Size { get; set; }
        public User User { get; set; }
        public void Validate()
        {
            AddNotifications(
                    new Contract()
                    .HasMinLen(Name, 3, "Name", "Name should have at least 3 chars")
                    .IsNotNull(User,"User","User not null")
                );
        }
    }
}