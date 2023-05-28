using FDT.Management.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Base.Commands
{
    public abstract class BaseCommand
    {
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
