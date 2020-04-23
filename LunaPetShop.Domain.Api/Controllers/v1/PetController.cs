using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Commands.Contracts;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LunaPetShop.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/pet")]
    public class PetController : ControllerBase
    {
        private readonly CreatePetHandler _handler;
        public PetController(CreatePetHandler handler)
        {
            _handler = handler;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CommandCreatePet command)
        {  
            var result = (CommandResult)_handler.handle(command);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
