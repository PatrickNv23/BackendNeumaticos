using Application.Common.Interfaces;
using Application.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByPrice
{
    public class GetTiresByPriceQuery : IRequest<List<TireDto>>
    {
        public string? OptionPrice { get; set; }
    }

    public class GetTiresByPriceQueryHandler : IRequestHandler<GetTiresByPriceQuery, List<TireDto>>
    {

        private readonly IApplicationDbContext _context;


        public GetTiresByPriceQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<TireDto>> Handle(GetTiresByPriceQuery request, CancellationToken cancellationToken)
        {
            if (request.OptionPrice == "option100y200")
            {
                return _context.Tires
               .Where(tire => tire.Price >= 100 && tire.Price <= 200)
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
            return _context.Tires
               .Where(tire => tire.Price >= 100 && tire.Price <= 200)
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
