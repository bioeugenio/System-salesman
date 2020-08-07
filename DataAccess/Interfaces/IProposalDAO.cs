using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.DataAccess.DAO.Interfaces
{
    public interface IProposalDAO 
    {
        void Create(IProposal proposal);
        Task CreateAsync(IProposal proposal);
        void Delete(Guid id);
        void Delete(IProposal proposal);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(IProposal proposal);
        List<IProposal> List();
        Task<List<IProposal>> ListAsync();
        IProposal Read(Guid id);
        Task<IProposal> ReadAsync(Guid id);
        void Update(IProposal proposal);
        Task UpdateAsync(IProposal proposal);
    }
}