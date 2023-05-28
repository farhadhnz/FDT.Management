using FDT.Management.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Persistence.Entities
{
    public class DigitalTwinEntity : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int ProjectId { get; set; }
        public int DigitalTwinTypeId { get; set; }

        public virtual ICollection<DigitalTwinPropertyEntity>? Properties { get; set; }
    }
}
