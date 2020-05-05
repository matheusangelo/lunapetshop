using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;
using MediatR;

namespace LunaPetShop.Domain.Commands.Produtcs
{
    public class CreateProductCommand : Notifiable, ICommand
    {
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
                .HasMinLen(AnimalType, 3, "Email", "Invalid Email")
            );
        }
    }
}