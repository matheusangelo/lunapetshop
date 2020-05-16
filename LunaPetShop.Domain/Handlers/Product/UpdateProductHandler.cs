using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Commands.Produtcs;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers.Products
{
    public class UpdateProductHandler : IHandler<UpdateProductCommand>
    {
        public readonly IProductRespository _productRepository;
        public UpdateProductHandler(IProductRespository productRespository)
        {
            _productRepository = productRespository;
        }

        public ICommandResult handle(UpdateProductCommand command)
        {
            //fast fail validations
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command invalid", false, command.Notifications);
            }

            var product = _productRepository.GetById(command.Id);

            product.Name = command.Name;
            product.Price = command.Price;
            product.Reviews = command.Reviews;
            product.Amount = command.Amount;
            product.AnimalType = command.AnimalType;

            _productRepository.Update(product);

            return new CommandResult("Product created", true, command);
        }
    }
}