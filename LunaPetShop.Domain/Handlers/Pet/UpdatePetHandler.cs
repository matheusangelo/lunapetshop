using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Handlers.Contracts;
using LunaPetShop.Domain.Repository;

namespace LunaPetShop.Domain.Handlers
{
    public class UpdatePetHandler : IHandler<CommandUpdatePet>
    {
        private readonly IPetRepository _petRepository;
        public UpdatePetHandler(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public ICommandResult handle(CommandUpdatePet command)
        {
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command Invalid creating a Pet", false, command);
            }

            var pet = _petRepository.GetPetById(command.Id);

            pet.Name = command.Name ;
            pet.Weigth = command.Weigth ;
            pet.Age = command.Age ;
            pet.Sex = command.Sex ;
            pet.Breed = command.Breed ;
            pet.Castrated = command.Castrated ;
            pet.Size = command.Size ;
            pet.User = command.User ;

            _petRepository.UpdatePet(pet);

            return new CommandResult("Pet Updated", true, command);
        }
    }
}