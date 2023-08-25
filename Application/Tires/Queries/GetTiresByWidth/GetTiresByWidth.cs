using Application.Common.Interfaces;
using Application.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByWidth
{
    public class GetTiresByWidthQuery : IRequest<List<TireDto>>
    {
        public int? Witdh { get; set; }
    }

    public class GetTiresByWidthQueryHandler : IRequestHandler<GetTiresByWidthQuery, List<TireDto>>
    {

        private readonly IApplicationDbContext _context;


        public GetTiresByWidthQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TireDto>> Handle(GetTiresByWidthQuery request, CancellationToken cancellationToken)
        {
            return _context.Tires
                .Where(tire => tire.Width == request.Witdh)
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
