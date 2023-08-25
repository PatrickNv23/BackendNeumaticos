using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class TireDbContext : DbContext, IApplicationDbContext
    {

        public TireDbContext(DbContextOptions<TireDbContext> options)
       : base(options)
        {
        }

        public DbSet<Tire> Tires { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
