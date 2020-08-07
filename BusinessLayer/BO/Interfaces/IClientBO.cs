using Hiq.Dxs.SystemSalesman.BusinessLayer.OperationResults;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.BusinessLayer.BO
{
    public interface IClientBO 
    {
        OperationResult Create(IClient client);
        Task<OperationResult> CreateAsync(IClient client);
        OperationResult Delete(IClient client);
        OperationResult Delete(Guid id);
        Task<OperationResult> DeleteAsync(IClient client);
        Task<OperationResult> DeleteAsync(Guid id);
        OperationResult<List<IClient>> Filter(Func<IClient, bool> predicate);
        Task<OperationResult<List<IClient>>> FilterAsync(Func<IClient, bool> predicate);
        OperationResult<List<IClient>> List();
        Task<OperationResult<List<IClient>>> ListAsync();
        OperationResult<List<IClient>> ListUndeleted();
        Task<OperationResult<List<IClient>>> ListUndeletedAsync();
        OperationResult<IClient> Read(Guid id);
        Task<OperationResult<IClient>> ReadAsync(Guid id);
        Task ReadAsync(object clientId);
        OperationResult Update(IClient client);
        Task<OperationResult> UpdateAsync(IClient client);
    }
}