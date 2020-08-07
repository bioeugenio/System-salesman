using Hiq.Dxs.SystemSalesman.DataAccess.Context;
using Hiq.Dxs.SystemSalesman.DataAccess.DAO.Interfaces;
using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiq.Dxs.SystemSalesman.DataAccess.DAO
{
    public class JobDAO : IJobDAO
    {
        /*
         * CRUD + LIST
         */

        private ApplicationContext _context;

        public JobDAO(ApplicationContext context)
        {
            _context = context;
        }

        #region CREATE

        public void Create(IJob client)
        {

            _context.Set<IJob>().Add(client);
            _context.SaveChanges();
        }

        public async Task CreateAsync(IJob client)
        {

            await _context.Set<IJob>().AddAsync(client);
            await _context.SaveChangesAsync();
        }

        #endregion

        #region READ

        public IJob Read(Guid id)
        {

            return _context.Set<IJob>().FirstOrDefault(x => x.Id == id);
        }

        public async Task<IJob> ReadAsync(Guid id)
        {

            return await _context.Set<IJob>().FirstOrDefaultAsync(x => x.Id == id);
        }

        #endregion

        #region UPDATE

        public void Update(IJob client)
        {

            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task UpdateAsync(IJob client)
        {

            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        #endregion

        #region DELETE

        public void Delete(IJob client)
        {
            client.IsDeleted = true;
            Update(client);
        }

        public void Delete(Guid id)
        {
            var client = Read(id);

            if (client == null)
                return;

            Delete(client);
        }

        public async Task DeleteAsync(IJob client)
        {
            client.IsDeleted = true;
            await UpdateAsync(client);
        }

        public async Task DeleteAsync(Guid id)
        {
            var client = await ReadAsync(id);

            if (client == null)
                return;

            await DeleteAsync(client);
        }

        #endregion

        #region LIST

        public List<IJob> List()
        {

            return _context.Jobs.ToList();
        }

        public async Task<List<IJob>> ListAsync()
        {

            return await _context.Jobs.ToListAsync();
        }

        #endregion
    }
}
