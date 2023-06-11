using FDT.Management.Base.CommandHandlers;
using FDT.Management.Base.Persistence;
using FDT.Management.Core.Commands.Project;
using FDT.Management.Core.Mapping;
using FDT.Management.Persistence.Entities;

namespace FDT.Management.Core.CommandHandlers.Project
{
    public class CreateProjectCommandHandler : ICommandHandler<CreateProjectCommand>
    {
        private readonly IProjectRepository<DigitalTwinProject> projectRepository;

        public CreateProjectCommandHandler(IProjectRepository<DigitalTwinProject> projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public async Task HandleAsync(CreateProjectCommand command)
        {
            // mapping
            var project = ProjectMapper.Map(command);

            // insertion of DT
            await projectRepository.Create(project);
        }
    }
}
