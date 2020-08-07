using Hiq.Dxs.SystemSalesman.BusinessLayer.OperationResults;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.BusinessLayer.BO
{
    public interface IProposalBO
    {
        OperationResult Create(IProposal proposal);
        Task<OperationResult> CreateAsync(IProposal proposal);
        OperationResult Delete(Guid id);
        OperationResult Delete(IProposal proposal);
        Task<OperationResult> DeleteAsync(Guid id);
        Task<OperationResult> DeleteAsync(IProposal proposal);
        OperationResult<List<IProposal>> Filter(Func<IProposal, bool> predicate);
        Task<OperationResult<List<IProposal>>> FilterAsync(Func<IProposal, bool> predicate);
        OperationResult<List<IProposal>> List();
        Task<OperationResult<List<IProposal>>> ListAsync();
        OperationResult<List<IProposal>> ListUndeleted();
        Task<OperationResult<List<IProposal>>> ListUndeletedAsync();
        OperationResult<IProposal> Read(Guid id);
        Task<OperationResult<IProposal>> ReadAsync(Guid id);
        OperationResult Update(IProposal proposal);
        Task<OperationResult> UpdateAsync(IProposal proposal);
    }
}