using Application.Tires.Queries.GetTiresByRing;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByWidth
{
    public class GetTiresByWidthQueryValidator : AbstractValidator<GetTiresByWidthQuery>
    {
        public GetTiresByWidthQueryValidator()
        {
            RuleFor(x => x.Witdh).NotEmpty().GreaterThan(150);
        }
    }
}
