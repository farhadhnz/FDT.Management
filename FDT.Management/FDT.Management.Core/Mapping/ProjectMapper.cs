using FDT.Management.Core.Commands.Project;
using FDT.Management.Persistence.Entities;

namespace FDT.Management.Core.Mapping
{
    public static class ProjectMapper
    {
        public static DigitalTwinProject Map(CreateProjectCommand command)
        {
            var project = new DigitalTwinProject();
            project.ProjectName = command.Project.ProjectName;
            project.ProjectType = command.Project.ProjectType;
            project.DateCreated = DateTime.UtcNow;
            project.DateModified = DateTime.UtcNow;

            return project;
        }
    }
}
