using FDT.Management.Base.CommandHandlers;
using FDT.Management.Base.Commands;
using FDT.Management.Base.Entities;
using FDT.Management.Core.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace FDT.Management.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateDigitalTwinController : ControllerBase
    {

        private readonly ILogger<CreateDigitalTwinController> _logger;
        private readonly ICommandHandler<CreateDigitalTwinCommand> _commandHandler;

        public CreateDigitalTwinController(ILogger<CreateDigitalTwinController> logger, ICommandHandler<CreateDigitalTwinCommand> commandHandler)
        {
            _logger = logger;
            _commandHandler = commandHandler;
        }

        [HttpPost(Name = "CreateDigitalTwin")]
        public async Task<ActionResult<BaseDigitalTwin>> CreateDigitalTwin([FromBody] CreateDigitalTwinCommand command)
        {
            try
            {
                // Validate command
                if (command == null)
                {
                    return BadRequest("Command cannot be null.");
                }

                // Use the command handler to create the digital twin
                await _commandHandler.HandleAsync(command);

                // Return the created digital twin
                return StatusCode(StatusCodes.Status200OK, "Item added successfully");
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "An error occurred while creating the digital twin.");

                // Return a server error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating the digital twin.");
            }
        }
    }
}