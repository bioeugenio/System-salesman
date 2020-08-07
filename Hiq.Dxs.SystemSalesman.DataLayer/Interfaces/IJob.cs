using System;
using System.Collections.Generic;

namespace Hiq.Dxs.SystemSalesman.DataLayer.Interfaces
{
    public interface IJob : IEntity
    {
        string Address { get; set; }
        double Budget { get; set; }
        Client Client { get; set; }
        Guid ClientId { get; set; }
        DateTime EndDate { get; set; }
        ICollection<Proposal> Proposals { get; set; }
        bool Rated { get; set; }
        double Rating { get; set; }
        DateTime StartDate { get; set; }
        string Status { get; set; }
    }
}