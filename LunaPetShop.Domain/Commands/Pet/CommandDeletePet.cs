using System;
using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Commands
{
    public class CommandDeletePet : Notifiable, ICommand
    {
        public CommandDeletePet(Guid petId)
        {
            Id = petId;
        }

        public Guid Id { get; set; }
        public void Validate()
        {
            AddNotifications(
                    new Contract()
                    .IsNotNull(Id,"Pet","Pet not null")
                );
        }
    }
}