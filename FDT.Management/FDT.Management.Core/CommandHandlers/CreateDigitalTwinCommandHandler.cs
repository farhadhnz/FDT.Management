using FDT.Management.Base.CommandHandlers;
using FDT.Management.Base.Commands;
using FDT.Management.Base.Persistence;
using FDT.Management.Core.Mapping;
using FDT.Management.Persistence.Entities;

namespace FDT.Management.Core.CommandHandlers
{
    public class CreateDigitalTwinCommandHandler : ICommandHandler<CreateDigitalTwinCommand>
    {
        private readonly IDigitalTwinRepository<DigitalTwinEntity> dtRepository;
        private readonly IDigitalTwinPropertyRepository<DigitalTwinPropertyEntity> propertyRepository;

        public CreateDigitalTwinCommandHandler(IDigitalTwinRepository<DigitalTwinEntity> dtRepository, 
                                               IDigitalTwinPropertyRepository<DigitalTwinPropertyEntity> propertyRepository)
        {
            this.dtRepository = dtRepository;
            this.propertyRepository = propertyRepository;
        }
        public async Task HandleAsync(CreateDigitalTwinCommand command)
        {
            // mapping
            var digitalTwin = DigitalTwinMapper.Map(command);
            var digitalTwinProperties = DigitalTwinMapper.MapDetails(command);

            // insertion of DT
            await dtRepository.Create(digitalTwin);

            // insertion of Details
            foreach (var property in digitalTwinProperties)
            {
                property.DigitalTwinId = digitalTwin.Id;
                await propertyRepository.Create(property);
            }
        }
    }
}
