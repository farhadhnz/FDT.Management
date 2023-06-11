using FDT.Management.Base.Entities;

namespace FDT.Management.Base.Persistence
{
    public interface IProjectRepository<T> where T : BaseEntity
    {
        Task Create(T digitalTwin);
        T Update(T digitalTwin);
        void Delete(string id);
        T GetById(string id);
        List<T> GetAll();
        Task<List<T>> GetAllByProjectId(int id);
    }
}
