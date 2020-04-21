using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers
{
    public class DeletePetHandler : IHandler<CommandCreatePet>
    {
        private readonly IPetRepository _petRepository;
        public DeletePetHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public ICommandResult handle(CommandCreatePet command)
        {
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command Invalid delete a Pet", false, command);
            }
            

            _petRepository.DeletePet(command.Id);

            return new CommandResult("Pet Deleted", true, command);
        }
    }
}