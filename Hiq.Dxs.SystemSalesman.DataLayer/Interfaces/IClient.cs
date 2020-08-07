using System;
using System.Collections.Generic;

namespace Hiq.Dxs.SystemSalesman.DataLayer.Interfaces
{
    public interface IClient : IEntity
    {
        DateTime BeginDate { get; set; }
        string Country { get; set; }
        string FullName { get; set; }
        ICollection<Job> Jobs { get; set; }
    }
}