using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Handlers.Contracts;

namespace LunaPetShop.Domain.Handlers
{
    public class CreatePetHandler : IHandler<CommandCreatePet>
    {
        public ICommandResult handle(CommandCreatePet command)
        {
            command.Validate();

            if (command.Invalid){
                return new CommandResult("Command Invalid creating a Pet",false,command);
            }
            
            return new CommandResult("Pet Created",true,command);
        }
    }
}