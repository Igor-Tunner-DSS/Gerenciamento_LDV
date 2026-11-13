using LDV.Shop.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LDV.Shop.Infrastructure.Persistence
{
    public class ShopDbContext : DbContext, IUnitOfWork
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
    }
}
