using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Commands.Produtcs;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers.Products
{

    public class CreateProductHandler : IHandler<CreateProductCommand>
    {
        private readonly IProductRespository _productRespository;
        public CreateProductHandler(IProductRespository productRespository)
        {
            _productRespository = productRespository;
        }

        public ICommandResult handle(CreateProductCommand command)
        {
            //fast fail validations
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command invalid", false, command.Notifications);
            }

            var product = new Product();

            product.Name = command.Name;
            product.Price = command.Price;
            product.Reviews = command.Reviews;
            product.Amount = command.Amount;
            product.AnimalType = command.AnimalType;

            _productRespository.Add(product);

            return new CommandResult("Product created", true, product);
        }
    }
}