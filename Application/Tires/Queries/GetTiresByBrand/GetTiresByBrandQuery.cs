using Application.Common.Interfaces;
using Application.Dto;
using Application.Tires.Queries.ListTires;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTire
{
    public class GetTiresByBrandQuery : IRequest<List<TireDto>>
    {
        public string? Brand { get; set; }
    }

    public class GetTiresByBrandQueryHandler : IRequestHandler<GetTiresByBrandQuery, List<TireDto>>
    {

        private readonly IApplicationDbContext _context;


        public GetTiresByBrandQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TireDto>> Handle(GetTiresByBrandQuery request, CancellationToken cancellationToken)
        {
            return _context.Tires
                .Where(tire => tire.Brand == request.Brand)
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
