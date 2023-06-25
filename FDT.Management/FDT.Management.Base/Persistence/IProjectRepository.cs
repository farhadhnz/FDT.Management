using FDT.Management.Base.Entities;

namespace FDT.Management.Base.Persistence
{
    public interface IProjectRepository<T> where T : BaseEntity
    {
        Task Create(T project);
        Task Update(T project);
        Task Delete(int id);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
