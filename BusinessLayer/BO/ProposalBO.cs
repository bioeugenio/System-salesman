using Hiq.Dxs.SystemSalesman.BusinessLayer.OperationResults;
using Hiq.Dxs.SystemSalesman.DataAccess.DAO.Interfaces;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Hiq.Dxs.SystemSalesman.BusinessLayer.BO
{
    public class ProposalBO : IProposalBO
    {
        protected readonly IProposalDAO _dao;

        public ProposalBO(IProposalDAO dao)
        {
            _dao = dao;

        }

        TransactionOptions transactionOptions = new TransactionOptions
        {
            IsolationLevel = IsolationLevel.ReadCommitted,
            Timeout = TimeSpan.FromSeconds(30)
        };

        //public ClientBO()
        //{
        //    _dao = new ClientDAO();
        //}


        /*
         * CRUD + LIST
         */

        #region CREATE

        public virtual OperationResult Create(IProposal proposal)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Create(proposal);
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult> CreateAsync(IProposal proposal)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.CreateAsync(proposal);
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region READ

        public virtual OperationResult<IProposal> Read(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.Read(id);
                transactionScope.Complete();

                return new OperationResult<IProposal>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<IProposal>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult<IProposal>> ReadAsync(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ReadAsync(id);
                transactionScope.Complete();

                return new OperationResult<IProposal>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<IProposal>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region UPDATE

        public virtual OperationResult Update(IProposal proposal)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Update(proposal);
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        public Task ReadAsync(object proposalId)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<OperationResult> UpdateAsync(IProposal proposal)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.UpdateAsync(proposal);
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region DELETE

        public virtual OperationResult Delete(IProposal proposal)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Delete(proposal);
                transactionScope.Complete();

                return new OperationResult() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult() { Success = false, Exception = e };
            }
        }

        public virtual OperationResult Delete(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Delete(id);
                transactionScope.Complete();

                return new OperationResult() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult> DeleteAsync(IProposal proposal)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.DeleteAsync(proposal);
                transactionScope.Complete();

                return new OperationResult() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult> DeleteAsync(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.DeleteAsync(id);
                transactionScope.Complete();

                return new OperationResult() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult() { Success = false, Exception = e };
            }
        }

        #endregion

        #region LIST

        public virtual OperationResult<List<IProposal>> List()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List();
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult<List<IProposal>>> ListAsync()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region LIST UNDELETED

        public OperationResult<List<IProposal>> ListUndeleted()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List().Where(x => !x.IsDeleted).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        public async Task<OperationResult<List<IProposal>>> ListUndeletedAsync()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                result = result.Where(x => !x.IsDeleted).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region FILTER

        public OperationResult<List<IProposal>> Filter(Func<IProposal, bool> predicate)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List();
                result = result.Where(predicate).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Result = result, Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        public async Task<OperationResult<List<IProposal>>> FilterAsync(Func<IProposal, bool> predicate)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                result = result.Where(predicate).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IProposal>>() { Result = result, Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IProposal>>() { Success = false, Exception = e };
            }
        }

        #endregion
    }
}
