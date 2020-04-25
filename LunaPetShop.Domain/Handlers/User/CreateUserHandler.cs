using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers
{
    public class CreateUserHandler : IHandler<CommandCreateUser>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ICommandResult handle(CommandCreateUser command)
        {
            //fast fail validations
            command.Validate();

            //validate schema
            if (command.Invalid)
            {
                return new CommandResult("Invalid values request", false, command);
            }

            var user = new User();

            user.Name = command.Name;
            user.Email = command.Email;
            user.SurName = command.SurName;
            user.Password = command.Password;

            _userRepository.AddUser(user);

            return new CommandResult("User created with sucess", true, user);
        }
    }
}