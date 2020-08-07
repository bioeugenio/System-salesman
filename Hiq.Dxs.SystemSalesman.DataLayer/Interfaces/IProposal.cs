using System;

namespace Hiq.Dxs.SystemSalesman.DataLayer.Interfaces
{
    public interface IProposal : IEntity
    {
        Job Job { get; set; }
        Guid JobId { get; set; }
        string Message { get; set; }
        string Sender { get; set; }
    }
}