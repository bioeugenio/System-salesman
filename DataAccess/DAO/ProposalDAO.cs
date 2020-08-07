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
    public class ProposalDAO : IProposalDAO
    {
        /*
         * CRUD + LIST
         */

        /*
        * CRUD + LIST
        */

        private ApplicationContext _context;

        public ProposalDAO(ApplicationContext context)
        {
            _context = context;
        }

        #region CREATE

        public void Create(IProposal client)
        {

            _context.Set<IProposal>().Add(client);
            _context.SaveChanges();
        }

        public async Task CreateAsync(IProposal client)
        {

            await _context.Set<IProposal>().AddAsync(client);
            await _context.SaveChangesAsync();
        }

        #endregion

        #region READ

        public IProposal Read(Guid id)
        {

            return _context.Set<IProposal>().FirstOrDefault(x => x.Id == id);
        }

        public async Task<IProposal> ReadAsync(Guid id)
        {

            return await _context.Set<IProposal>().FirstOrDefaultAsync(x => x.Id == id);
        }

        #endregion

        #region UPDATE

        public void Update(IProposal client)
        {

            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task UpdateAsync(IProposal client)
        {

            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        #endregion

        #region DELETE

        public void Delete(IProposal client)
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

        public async Task DeleteAsync(IProposal client)
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

        public List<IProposal> List()
        {

            return _context.Proposals.ToList();
        }

        public async Task<List<IProposal>> ListAsync()
        {

            return await _context.Proposals.ToListAsync();
        }

        #endregion
    }
}

