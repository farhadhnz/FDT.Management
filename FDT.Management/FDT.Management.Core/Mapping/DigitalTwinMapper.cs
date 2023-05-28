using FDT.Management.Base.Commands;
using FDT.Management.Base.Entities;
using FDT.Management.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Core.Mapping
{
    public static class DigitalTwinMapper
    {
        public static DigitalTwinEntity Map(CreateDigitalTwinCommand command)
        {
            var digitalTwin = new DigitalTwinEntity();
            digitalTwin.Name = command.DigitalTwinModel.Name;
            digitalTwin.Description = command.DigitalTwinModel.Description;
            digitalTwin.DateCreated = DateTime.UtcNow;
            digitalTwin.DateModified = DateTime.UtcNow;
            digitalTwin.ProjectId = command.DigitalTwinModel.ProjectId;
            digitalTwin.DigitalTwinTypeId = command.DigitalTwinModel.DigitalTwinTypeId;

            return digitalTwin;
        }

        public static ICollection<DigitalTwinPropertyEntity> MapDetails(CreateDigitalTwinCommand command)
        {
            var properties = new List<DigitalTwinPropertyEntity>();
            foreach (var prop in command.DigitalTwinModel.Properties)
            {
                var property = new DigitalTwinPropertyEntity()
                {
                    PropertyName = prop.Key,
                    PropertyValue = prop.Value.ToString()
                };
                properties.Add(property);
            }
            return properties;
        }
    }
}
