using FDT.Management.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.Management.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DigitalTwinProject> Projects { get; set; }
        public DbSet<DigitalTwinEntity> DigitalTwins { get; set; }
        public DbSet<DigitalTwinPropertyEntity> DigitalTwinProps { get; set; }
        public DbSet<DigitalTwinTypeEntity> DigitalTwinTypes { get; set; }

    }
}
