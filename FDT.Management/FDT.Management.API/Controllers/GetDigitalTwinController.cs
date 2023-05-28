using FDT.Management.Base.Persistence;
using FDT.Management.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FDT.Management.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetDigitalTwinController : ControllerBase
    {

        private readonly ILogger<GetDigitalTwinController> _logger;
        private readonly IDigitalTwinRepository<DigitalTwinEntity> repository;

        public GetDigitalTwinController(ILogger<GetDigitalTwinController> logger, IDigitalTwinRepository<DigitalTwinEntity> repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<List<DigitalTwinEntity>> GetDigitalTwinsByProjectId(int id)
        {
            try
            {
                List<DigitalTwinEntity> digitalTwins = await repository.GetAllByProjectId(id);

                return digitalTwins;
            }
            catch (Exception ex)
            {
                // Log the error
                _logger.LogError(ex, "An error occurred while loading the digital twins.");

                throw;
            }
        }
    }
}