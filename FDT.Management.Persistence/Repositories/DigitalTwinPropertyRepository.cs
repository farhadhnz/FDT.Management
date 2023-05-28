using FDT.Management.Base.Persistence;
using FDT.Management.Persistence.Entities;

namespace FDT.Management.Persistence.Repositories
{
    public class DigitalTwinPropertyRepository : IDigitalTwinPropertyRepository<DigitalTwinPropertyEntity>
    {
        private readonly AppDbContext dbContext;

        public DigitalTwinPropertyRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Create(DigitalTwinPropertyEntity digitalTwinProperty)
        {
            await dbContext.DigitalTwinProps.AddAsync(digitalTwinProperty);

            await dbContext.SaveChangesAsync();
        }
    }
}
