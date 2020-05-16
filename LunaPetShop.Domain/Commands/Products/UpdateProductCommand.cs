using System;
using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;

namespace LunaPetShop.Domain.Commands.Produtcs
{
    public class UpdateProductCommand : Notifiable, ICommand
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double Reviews { get; set; }
        public string AnimalType { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .HasMinLen(Name, 3, "Name", "Name should have at least 3 chars")
                .IsNotNull(Price, "Price", "The price should not be empty or not null")
                .IsNotNull(Amount, "Amount", "Invalid Amount")
                .HasMinLen(AnimalType, 3, "Email", "Invalid Email")
            );
        }
    }
}