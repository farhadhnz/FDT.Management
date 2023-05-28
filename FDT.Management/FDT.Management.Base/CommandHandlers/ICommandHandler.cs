using FDT.Management.Base.Commands;
using FDT.Management.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Base.CommandHandlers
{
    public interface ICommandHandler<T> where T : BaseCommand
    {
        Task HandleAsync(T command);
    }
}
