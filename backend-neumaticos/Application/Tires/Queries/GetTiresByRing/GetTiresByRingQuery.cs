using Application.Common.Interfaces;
using Application.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByRing
{
    public class GetTiresByRingQuery : IRequest<List<TireDto>>
    {
        public int? Ring { get; set; }
    }

    public class GetTiresByRingQueryHandler : IRequestHandler<GetTiresByRingQuery, List<TireDto>>
    {

        private readonly IApplicationDbContext _context;


        public GetTiresByRingQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TireDto>> Handle(GetTiresByRingQuery request, CancellationToken cancellationToken)
        {
            return _context.Tires
                .Where(tire => tire.Ring == request.Ring)
                .Select(tire => new TireDto
                {
                    Id = tire.Id,
                    Photo = tire.Photo,
                    Brand = tire.Brand,
                    Description = tire.Description,
                    Supplier = tire.Supplier,
                    Price = tire.Price,
                    Profile = tire.Profile,
                    Width = tire.Width,
                    Ring = tire.Ring,
                })
                .ToListAsync();
        }
    }
}
