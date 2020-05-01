using System.Threading;
using System.Threading.Tasks;
using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Commands.Produtcs;
using LunaPetShop.Domain.Handlers.Contracts;
using MediatR;

namespace LunaPetShop.Domain.Handlers.Products
{

    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CommandResult>
    {
        public CreateProductHandler()
        {

        }

        public Task<CommandResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //fast fail validations
            request.Validate();

            if (request.Invalid)
            {
                return Task.FromResult(new CommandResult("Command invalid", false, request.Notifications));
            }

            return Task.FromResult(new CommandResult("Product created", true, request));
        }
    }
}