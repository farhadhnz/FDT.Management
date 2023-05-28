using FDT.Management.Base.Entities;

namespace FDT.Management.Base.Persistence
{
    public interface IDigitalTwinPropertyRepository<T> where T : BaseEntity
    {
        Task Create(T digitalTwinProperty);
    }
}
