using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.DataAccess.DAO.Interfaces
{
    public interface IClientDAO
    {
        void Create(IClient client);
        Task CreateAsync(IClient client);
        void Delete(IClient client);
        void Delete(Guid id);
        Task DeleteAsync(IClient client);
        Task DeleteAsync(Guid id);
        List<IClient> List();
        Task<List<IClient>> ListAsync();
        IClient Read(Guid id);
        Task<IClient> ReadAsync(Guid id);
        void Update(IClient client);
        Task UpdateAsync(IClient client);
    }
}