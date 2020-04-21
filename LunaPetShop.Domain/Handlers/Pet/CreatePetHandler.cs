using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers
{
    public class CreatePetHandler : IHandler<CommandCreatePet>
    {
        private readonly IPetRepository _petRepository;
        public CreatePetHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public ICommandResult handle(CommandCreatePet command)
        {
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command Invalid creating a Pet", false, command);
            }

            var pet = new Pet(command.Name,
                              command.Weigth,
                              command.Age,
                              command.Sex,
                              command.Breed,
                              command.Castrated,
                              command.Size,
                              command.User.Id,
                              command.User);

            _petRepository.AddPet(pet);

            return new CommandResult("Pet Created", true, command);
        }
    }
}