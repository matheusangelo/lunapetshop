using LunaPetShop.Domain.Commands.Contracts;

namespace LunaPetShop.Domain.Handlers.Contracts
{
    public interface IHandler<T>  where T : ICommand
    {
        ICommandResult handle(T command);
    }
}