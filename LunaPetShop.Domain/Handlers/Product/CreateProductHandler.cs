using System.Threading;
using System.Threading.Tasks;
using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Commands.Produtcs;
using LunaPetShop.Domain.Handlers.Contracts;
using MediatR;

namespace LunaPetShop.Domain.Handlers.Products
{

    public class CreateProductHandler : IHandler<CreateProductCommand>
    {
        private readonly IProductRespository _productRespository;
        public CreateProductHandler()
        {

        }

        public ICommandResult handle(CreateProductCommand command)
        {
            //fast fail validations
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command invalid", false, command.Notifications);
            }

            return new CommandResult("Product created", true, command);
        }
    }
}