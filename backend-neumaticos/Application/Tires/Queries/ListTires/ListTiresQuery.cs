using Application.Common.Interfaces;
using Application.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.ListTires
{
    public class ListTiresQuery : IRequest<List<TireDto>>
    {

    }

    public class ListTiresQueryHandler : IRequestHandler<ListTiresQuery, List<TireDto>>
    {

        private readonly IApplicationDbContext _context;


        public ListTiresQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TireDto>> Handle(ListTiresQuery request, CancellationToken cancellationToken)
        {
            return _context.Tires
                .AsNoTracking()
                .Select(tire => new TireDto
                {
                    Id = tire.Id,
                    Photo= tire.Photo,
                    Brand = tire.Brand,
                    Description = tire.Description,
                    Supplier = tire.Supplier,
                    Price= tire.Price,
                    Profile = tire.Profile,
                    Width = tire.Width,
                    Ring= tire.Ring,
                })
                .ToListAsync();
        }
    }
}
