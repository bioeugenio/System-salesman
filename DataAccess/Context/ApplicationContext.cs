using Hiq.Dxs.SystemSalesman.DataAccess.Properties;
using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiq.Dxs.SystemSalesman.DataAccess.Context
{
    public class ApplicationContext : IdentityDbContext 
    {
        public ApplicationContext() : base() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(Resources.ConnectionString);

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<IJob> Jobs { get; set; }
        public DbSet<IProposal> Proposals { get; set; }
        public DbSet<IClient> Clients { get; set; }
    }
}
