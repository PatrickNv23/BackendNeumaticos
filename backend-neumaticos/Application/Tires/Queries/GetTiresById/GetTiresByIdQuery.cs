using Application.Common.Interfaces;
using Application.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresById
{
    public class GetTiresByIdQuery : IRequest<List<TireDto>>
    {
        public int Id { get; set; }
    }

    public class GetTiresByIdQueryHandler : IRequestHandler<GetTiresByIdQuery, List<TireDto>>
    {

        private readonly IApplicationDbContext _context;


        public GetTiresByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TireDto>> Handle(GetTiresByIdQuery request, CancellationToken cancellationToken)
        {
            return _context.Tires
                .Where(tire => tire.Id == request.Id)
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
