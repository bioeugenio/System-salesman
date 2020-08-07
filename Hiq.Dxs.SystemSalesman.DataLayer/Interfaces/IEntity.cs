using System;

namespace Hiq.Dxs.SystemSalesman.DataLayer.Interfaces
{
    public interface IEntity
    {
        DateTime CreatedAt { get; }
        Guid Id { get; }
        bool IsDeleted { get; set; }
        DateTime UpdatedAt { get; }
    }
}