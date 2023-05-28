using FDT.Management.Base.Entities;
using System.Text.Json.Serialization;

namespace FDT.Management.Base.Commands
{
    public class CreateDigitalTwinCommand : BaseCommand
    {
        public DigitalTwin DigitalTwinModel { get; set; }


        [JsonConstructor]
        public CreateDigitalTwinCommand(DigitalTwin digitalTwin)
        {
            DigitalTwinModel = digitalTwin;
            Timestamp = DateTime.UtcNow;
        }
    }
}
