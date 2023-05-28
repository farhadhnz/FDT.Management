using FDT.Management.Base.Entities;
using System.Text.Json.Serialization;

namespace FDT.Management.Persistence.Entities
{
    public class DigitalTwinPropertyEntity : BaseEntity
    {
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public int DigitalTwinId { get; set; }
        [JsonIgnore]
        public virtual DigitalTwinEntity DigitalTwin { get; set; }
    }
}
