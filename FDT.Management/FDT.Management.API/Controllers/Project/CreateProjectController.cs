using FDT.Management.Base.CommandHandlers;
using FDT.Management.Core.Commands.Project;
using FDT.Management.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FDT.Management.API.Controllers.Project
{
    [ApiController]
    [Route("[controller]")]
    public class CreateProjectController : ControllerBase
    {

        private readonly ILogger<CreateProjectController> _logger;
        private readonly ICommandHandler<CreateProjectCommand> _commandHandler;

        public CreateProjectController(ILogger<CreateProjectController> logger, ICommandHandler<CreateProjectCommand> commandHandler)
        {
            _logger = logger;
            _commandHandler = commandHandler;
        }

        [HttpPost(Name = "CreateProject")]
        public async Task<ActionResult<DigitalTwinProject>> CreateProject([FromBody] CreateProjectCommand command)
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
                _logger.LogError(ex, "An error occurred while creating the project.");

                // Return a server error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating the project.");
            }
        }
    }
}
