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
    public class JobBO : IJobBO
    {
        protected readonly IJobDAO _dao;

        public JobBO(IJobDAO dao)
        {
            _dao = dao;

        }

        TransactionOptions transactionOptions = new TransactionOptions
        {
            IsolationLevel = IsolationLevel.ReadCommitted,
            Timeout = TimeSpan.FromSeconds(30)
        };

        //public JobBO()
        //{
        //    _dao = new ClientDAO();
        //}


        /*
         * CRUD + LIST
         */

        #region CREATE

        public virtual OperationResult Create(IJob client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Create(client);
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult> CreateAsync(IJob client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.CreateAsync(client);
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region READ

        public virtual OperationResult<IJob> Read(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.Read(id);
                transactionScope.Complete();

                return new OperationResult<IJob>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<IJob>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult<IJob>> ReadAsync(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ReadAsync(id);
                transactionScope.Complete();

                return new OperationResult<IJob>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<IJob>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region UPDATE

        public virtual OperationResult Update(IJob client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Update(client);
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        public Task ReadAsync(object jobId)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<OperationResult> UpdateAsync(IJob client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.UpdateAsync(client);
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region DELETE

        public virtual OperationResult Delete(IJob client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Delete(client);
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

        public async virtual Task<OperationResult> DeleteAsync(IJob client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.DeleteAsync(client);
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

        public virtual OperationResult<List<IJob>> List()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List();
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult<List<IJob>>> ListAsync()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region LIST UNDELETED

        public OperationResult<List<IJob>> ListUndeleted()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List().Where(x => !x.IsDeleted).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        public async Task<OperationResult<List<IJob>>> ListUndeletedAsync()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                result = result.Where(x => !x.IsDeleted).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region FILTER

        public OperationResult<List<IJob>> Filter(Func<IJob, bool> predicate)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List();
                result = result.Where(predicate).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Result = result, Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        public async Task<OperationResult<List<IJob>>> FilterAsync(Func<IJob, bool> predicate)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                result = result.Where(predicate).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IJob>>() { Result = result, Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IJob>>() { Success = false, Exception = e };
            }
        }

        #endregion
    }
}
