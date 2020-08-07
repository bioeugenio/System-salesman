using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.DataAccess.DAO.Interfaces
{
    public interface IJobDAO 
    {
        void Create(IJob job);
        Task CreateAsync(IJob job);
        void Delete(Guid id);
        void Delete(IJob job);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(IJob job);
        List<IJob> List();
        Task<List<IJob>> ListAsync();
        IJob Read(Guid id);
        Task<IJob> ReadAsync(Guid id);
        void Update(IJob job);
        Task UpdateAsync(IJob job);
    }
}