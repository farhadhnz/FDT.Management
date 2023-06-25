using FDT.Management.Base.Entities;
using System.Text.Json.Serialization;

namespace FDT.Management.Base.Commands
{
    public class GetDigitalTwinsCommand : BaseCommand
    {
        public ICollection<DigitalTwin> DigitalTwinModels { get; set; }


        [JsonConstructor]
        public GetDigitalTwinsCommand()
        {
            DigitalTwinModels = new List<DigitalTwin>();
        }
    }
}
