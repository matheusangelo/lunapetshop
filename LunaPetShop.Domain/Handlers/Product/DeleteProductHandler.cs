using System;
using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Commands.Produtcs;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers.Products
{
    public class DeleteProductHandler
    {
        public readonly IProductRespository _productRepository;

        public DeleteProductHandler(IProductRespository productRespository)
        {
            _productRepository = productRespository;

        }

        public ICommandResult handle(Guid Id)
        {
            var command = _productRepository.GetById(Id);

            //fast fail validations

            if (command == null)
            {
                return new CommandResult("Command invalid", false, command);
            }

            _productRepository.Delete(command);

            return new CommandResult("Product Deleted", true, command);
        }
    }
}