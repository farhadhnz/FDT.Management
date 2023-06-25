using FDT.Management.Base.Persistence;
using FDT.Management.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FDT.Management.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {

        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectRepository<DigitalTwinProject> repository;

        public ProjectController(ILogger<ProjectController> logger, IProjectRepository<DigitalTwinProject> repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<DigitalTwinProject> GetProjectById(int id)
        {
            try
            {
                var project = await repository.GetById(id);

                return project;
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "An error occurred while loading the project.");

                throw;
            }
        }

        [HttpGet]
        public async Task<List<DigitalTwinProject>> GetProjects()
        {
            try
            {
                var projects = await repository.GetAll();

                return projects;
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "An error occurred while loading the project.");

                throw;
            }
        }

        [HttpPut("{id}", Name = "UpdateProject")]
        public async Task<IActionResult> UpdateProject(int id, [FromBody] DigitalTwinProject project)
        {
            try
            {
                var projectDb = await repository.GetById(id);

                if (projectDb == null)
                {
                    return NotFound($"Project with ID {id} not found.");
                }

                await repository.Update(project);

                return Ok("Project updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the project.");

                // Return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the project.");
            }
        }

        [HttpDelete("{id}", Name = "DeleteProject")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            try
            {
                var project = await repository.GetById(id);

                if (project == null)
                {
                    return NotFound($"Project with ID {id} not found.");
                }

                await repository.Delete(id);

                return Ok("Project deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the project.");

                // Return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the project.");
            }
        }
    }
}