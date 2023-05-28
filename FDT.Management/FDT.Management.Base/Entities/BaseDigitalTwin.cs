using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Base.Entities
{
    public abstract class BaseDigitalTwin
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int ProjectId { get; set; }
        public int DigitalTwinTypeId { get; set; }

        public Dictionary<string, object> Properties { get; set; }
    }
}
