using Hiq.Dxs.SystemSalesman.BusinessLayer.OperationResults;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.BusinessLayer.BO
{
    public interface IJobBO
    {
        OperationResult Create(IJob job);
        Task<OperationResult> CreateAsync(IJob job);
        OperationResult Delete(Guid id);
        OperationResult Delete(IJob job);
        Task<OperationResult> DeleteAsync(Guid id);
        Task<OperationResult> DeleteAsync(IJob job);
        OperationResult<List<IJob>> Filter(Func<IJob, bool> predicate);
        Task<OperationResult<List<IJob>>> FilterAsync(Func<IJob, bool> predicate);
        OperationResult<List<IJob>> List();
        Task<OperationResult<List<IJob>>> ListAsync();
        OperationResult<List<IJob>> ListUndeleted();
        Task<OperationResult<List<IJob>>> ListUndeletedAsync();
        OperationResult<IJob> Read(Guid id);
        Task<OperationResult<IJob>> ReadAsync(Guid id);
        OperationResult Update(IJob job);
        Task<OperationResult> UpdateAsync(IJob job);
    }
}