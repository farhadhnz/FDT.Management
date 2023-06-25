using FDT.Management.Base.Persistence;
using FDT.Management.Persistence.Entities;
using FDT.WindTurbineLib.Simulation;
using Microsoft.AspNetCore.Mvc;

namespace FDT.Management.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimulationController : ControllerBase
    {

        private readonly ILogger<SimulationController> _logger;
        private readonly IDigitalTwinRepository<DigitalTwinEntity> dtRepository;

        public SimulationController(ILogger<SimulationController> logger, IDigitalTwinRepository<DigitalTwinEntity> dtRepository)
        {
            _logger = logger;
            this.dtRepository = dtRepository;
        }

        [HttpPost("{digitalTwinId}/{simulatorId}")]
        public async Task<IActionResult> RunSimulationForDigitalTwin(int digitalTwinId, int simulatorId)
        {
            try
            {
                var digitalTwin = await dtRepository.GetById(digitalTwinId);
                var rotorDiameter = double.Parse(digitalTwin.Properties
                                        .FirstOrDefault(p => p.PropertyName == "RotorDiameter").PropertyValue);

                // TODO: Load the simulator with the specified ID from your data source

                var simulatedData = await WindTurbineSimpleSimulation.Simulate(rotorDiameter);
                var windSpeeds = simulatedData.Select(t => t.Item1).ToArray();
                var powerOutputs = simulatedData.Select(t => t.Item2).ToArray();



                return Ok(new { message = "Simulation started successfully", windSpeeds, powerOutputs });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while starting the simulation.");
            }
        }
    }
}