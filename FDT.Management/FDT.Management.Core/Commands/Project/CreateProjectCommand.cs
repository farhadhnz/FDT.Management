using FDT.Management.Base.Commands;
using FDT.Management.Contracts;

namespace FDT.Management.Core.Commands.Project
{
    public class CreateProjectCommand : BaseCommand
    {
        public DigitalTwinProjectContract Project { get; set; }

        public CreateProjectCommand(DigitalTwinProjectContract project)
        {
            Project = project;
        }
    }
}
