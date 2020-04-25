using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Handlers;
using LunaPetShop.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LunaPetShop.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/pet")]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;
        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CommandCreatePet command,
                                             [FromServices] CreatePetHandler handler)
        {
            var result = (CommandResult)handler.handle(command);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] CommandDeletePet command,
                                               [FromServices] DeletePetHandler handler)
        {
            var result = (CommandResult)handler.handle(command);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }


        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CommandUpdatePet command,
                                            [FromServices] UpdatePetHandler handler)
        {
            var result = (CommandResult)handler.handle(command);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(_petRepository.GetAllByEmail("matheusangelo10@gmail.com"));
        }
    }
}
