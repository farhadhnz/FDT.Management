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
        public async Task Delete(int id)
        {
            var project = await dbContext.Projects.FirstOrDefaultAsync(p => p.Id == id);

            if (project != null)
            {
                dbContext.Projects.Remove(project);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<DigitalTwinProject>> GetAll()
        {
            return await dbContext.Projects.ToListAsync();
        }

        public async Task<DigitalTwinProject> GetById(int id)
        {
            return await dbContext.Projects
                .FirstOrDefaultAsync(project => project.Id == id);
        }

        public async Task Update(DigitalTwinProject project)
        {
            var dbProject = await dbContext.Projects.FirstOrDefaultAsync(p => p.Id == project.Id);

            if (dbProject != null)
            {
                dbProject.ProjectName = project.ProjectName;
                dbProject.ProjectType = project.ProjectType;
                dbProject.DateModified = DateTime.Now;
                
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
