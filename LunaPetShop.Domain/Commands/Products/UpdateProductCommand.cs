using Flunt.Notifications;
using Flunt.Validations;
using LunaPetShop.Domain.Commands.Contracts;

namespace LunaPetShop.Domain.Commands.Produtcs
{
    public class UpdateProductCommand : Notifiable, ICommand
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
                .IsNull(Price, "Price", "The price should not be empty or null")
                .IsNull(Amount, "Email", "Invalid Email")
                .HasMinLen(AnimalType, 3, "Email", "Invalid Email")
            );
        }
    }
}