﻿using FDT.Management.Base.Entities;

namespace FDT.Management.Base.Persistence
{
    public interface IDigitalTwinRepository<T> where T : BaseEntity
    {
        Task Create(T digitalTwin);
        T Update(T digitalTwin);
        void Delete(string id);
        Task<T> GetById(int id);
        List<T> GetAll();
        Task<List<T>> GetAllByProjectId(int id);
    }
}
