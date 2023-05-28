using FDT.Management.Base.Entities;

namespace FDT.Management.Persistence.Entities
{
    public class DigitalTwinProject : BaseEntity
    {
        public string? ProjectName { get; set; }

        public virtual ICollection<DigitalTwinEntity>? DigitalTwins { get; set; }
    }
}
