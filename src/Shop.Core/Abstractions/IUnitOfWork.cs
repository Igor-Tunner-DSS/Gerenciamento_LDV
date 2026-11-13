using System;
using System.Collections.Generic;
using System.Text;

namespace LDV.Shop.Core.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
