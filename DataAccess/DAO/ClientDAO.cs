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
    public class ClientDAO : IClientDAO
    {
        /*
         * CRUD + LIST
         */

        private ApplicationContext _context;

        public ClientDAO(ApplicationContext context)
        {
            _context = context;
        }

        #region CREATE

        public void Create(IClient client)
        {

            _context.Set<IClient>().Add(client);
            _context.SaveChanges();
        }

        public async Task CreateAsync(IClient client)
        {
            
            await _context.Set<IClient>().AddAsync(client);
            await _context.SaveChangesAsync();
        }

        #endregion

        #region READ

        public IClient Read(Guid id)
        {
            
            return _context.Set<IClient>().FirstOrDefault(x => x.Id == id);
        }

        public async Task<IClient> ReadAsync(Guid id)
        {
            
            return await _context.Set<IClient>().FirstOrDefaultAsync(x => x.Id == id);
        }

        #endregion

        #region UPDATE

        public void Update(IClient client)
        {

            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task UpdateAsync(IClient client)
        {

            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        #endregion

        #region DELETE

        public void Delete(IClient client)
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

        public async Task DeleteAsync(IClient client)
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

        public List<IClient> List()
        {
            
            return _context.Clients.ToList();
        }

        public async Task<List<IClient>> ListAsync()
        {
           
            return await _context.Clients.ToListAsync();
        }

        #endregion
    }
}
