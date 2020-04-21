using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Commands
{
    public class CommandDeletePet : Notifiable, ICommand
    {
        public CommandDeletePet(Pet pet)
        {
            Pet = pet;
        }

        public Pet Pet { get; set; }
        public void Validate()
        {
            AddNotifications(
                    new Contract()
                    .IsNotNull(Pet,"Pet","Pet not null")
                );
        }
    }
}