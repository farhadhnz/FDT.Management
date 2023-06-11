using FDT.Management.Base.Entities;

namespace FDT.Management.Persistence.Entities
{
    public class DigitalTwinProject : BaseEntity
    {
        public string? ProjectName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int ProjectType { get; set; }

        public virtual ICollection<DigitalTwinEntity>? DigitalTwins { get; set; }
    }
}
