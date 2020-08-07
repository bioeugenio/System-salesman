using Hiq.Dxs.SystemSalesman.BusinessLayer.BO;
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
    public class ClientBO : IClientBO
    {
        protected readonly IClientDAO _dao;

        public ClientBO(IClientDAO dao)
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

        public virtual OperationResult Create(IClient client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Create(client);
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult> CreateAsync(IClient client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.CreateAsync(client);
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region READ

        public virtual OperationResult<IClient> Read(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.Read(id);
                transactionScope.Complete();

                return new OperationResult<IClient>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<IClient>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult<IClient>> ReadAsync(Guid id)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ReadAsync(id);
                transactionScope.Complete();

                return new OperationResult<IClient>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<IClient>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region UPDATE

        public virtual OperationResult Update(IClient client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                _dao.Update(client);
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        public Task ReadAsync(object clientId)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<OperationResult> UpdateAsync(IClient client)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                await _dao.UpdateAsync(client);
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region DELETE

        public virtual OperationResult Delete(IClient client)
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

        public async virtual Task<OperationResult> DeleteAsync(IClient client)
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

        public virtual OperationResult<List<IClient>> List()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List();
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        public async virtual Task<OperationResult<List<IClient>>> ListAsync()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region LIST UNDELETED

        public OperationResult<List<IClient>> ListUndeleted()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List().Where(x => !x.IsDeleted).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        public async Task<OperationResult<List<IClient>>> ListUndeletedAsync()
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                result = result.Where(x => !x.IsDeleted).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Success = true, Result = result };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        #endregion

        #region FILTER

        public OperationResult<List<IClient>> Filter(Func<IClient, bool> predicate)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = _dao.List();
                result = result.Where(predicate).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Result = result, Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        public async Task<OperationResult<List<IClient>>> FilterAsync(Func<IClient, bool> predicate)
        {
            try
            {
                using var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
                var result = await _dao.ListAsync();
                result = result.Where(predicate).ToList();
                transactionScope.Complete();

                return new OperationResult<List<IClient>>() { Result = result, Success = true };
            }
            catch (Exception e)
            {
                return new OperationResult<List<IClient>>() { Success = false, Exception = e };
            }
        }

        #endregion
    }
}
