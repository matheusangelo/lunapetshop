using System;
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
        private readonly IUserRepository _userRespository;

        public CreatePetHandler(IPetRepository petRepository, IUserRepository userRepository)
        {
            _petRepository = petRepository;
            _userRespository = userRepository;
        }
        public ICommandResult handle(CommandCreatePet command)
        {
            command.Validate();

            if (command.Invalid)
            {
                return new CommandResult("Command Invalid creating a Pet", false, command);
            }

            var user = _userRespository.GetByEmail(command.UserEmail);

            var pet = new Pet(command.Name,
                              command.Weigth,
                              command.Age,
                              command.Sex,
                              command.Breed,
                              command.Castrated,
                              command.Size,
                              user.Id,
                              user);

            _petRepository.AddPet(pet);

            return new CommandResult("Pet Created", true, command);
        }
    }
}