using FDT.Management.Base.Persistence;
using FDT.Management.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace FDT.Management.Persistence.Repositories
{
    public class ProjectRepository : IProjectRepository<DigitalTwinProject>
    {
        private readonly AppDbContext dbContext;

        public ProjectRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Create(DigitalTwinProject project)
        {
            await dbContext.Projects.AddAsync(project);

            await dbContext.SaveChangesAsync();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<DigitalTwinProject> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<DigitalTwinProject>> GetAllByProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public DigitalTwinProject GetById(string id)
        {
            throw new NotImplementedException();
        }

        public DigitalTwinProject Update(DigitalTwinProject digitalTwin)
        {
            throw new NotImplementedException();
        }
    }
}
