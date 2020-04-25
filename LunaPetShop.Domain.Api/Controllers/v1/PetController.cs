using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunaPetShop.Domain.Commands;
using LunaPetShop.Domain.Handlers;
using LunaPetShop.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Post([FromBody] CommandCreatePet command,
                                             [FromServices] CreatePetHandler handler)
        {
            var result = (CommandResult)handler.handle(command);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{Id}")]
        public ActionResult Delete(Guid Id, [FromServices] DeletePetHandler handler)
        {
            try
            {
                var commandDeletePet = new CommandDeletePet(Id);
                var result = (CommandResult)handler.handle(commandDeletePet);

                if (!result.Success)
                    return BadRequest(result);


                return Ok(result);

            }
            catch (Exception err)
            {
                return BadRequest(err);
            }


        }


        [HttpPut]
        [Route("{Id}")]

        public ActionResult Put([FromBody] CommandUpdatePet command,
                                [FromServices] UpdatePetHandler handler)
        {
            
            var result = (CommandResult)handler.handle(command);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_petRepository.GetAllByEmail("matheusangelo10@gmail.com"));
        }
    }
}
