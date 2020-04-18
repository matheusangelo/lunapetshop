using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Handlers.Contracts;

namespace LunaPetShop.Domain.Handlers
{
    public class CreateUserHandler : IHandler<CommandCreateUser>
    {
        public ICommandResult handle(CommandCreateUser command)
        {
            //fast fail validations
            command.Validate();

            //validate schema
            if(command.Invalid){
                return new CommandResult("Invalid values request",false,command);    
            }

            return new CommandResult("User created with sucess",true,command);   
        }
    }
}