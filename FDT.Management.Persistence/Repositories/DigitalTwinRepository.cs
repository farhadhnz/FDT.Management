using FDT.Management.Base.Persistence;
using FDT.Management.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace FDT.Management.Persistence.Repositories
{
    public class DigitalTwinRepository : IDigitalTwinRepository<DigitalTwinEntity>
    {
        private readonly AppDbContext dbContext;

        public DigitalTwinRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Create(DigitalTwinEntity digitalTwin)
        {
            await dbContext.DigitalTwins.AddAsync(digitalTwin);

            await dbContext.SaveChangesAsync();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<DigitalTwinEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<DigitalTwinEntity>> GetAllByProjectId(int id)
        {
            var digitalTwins = await dbContext.DigitalTwins.Include(x => x.Properties)
                .Where(x => x.ProjectId == id).ToListAsync();
            return digitalTwins;
        }

        public DigitalTwinEntity GetById(string id)
        {
            throw new NotImplementedException();
        }

        public DigitalTwinEntity Update(DigitalTwinEntity digitalTwin)
        {
            throw new NotImplementedException();
        }
    }
}
