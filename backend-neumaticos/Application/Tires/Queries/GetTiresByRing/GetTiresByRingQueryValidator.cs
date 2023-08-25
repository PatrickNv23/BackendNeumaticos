using Application.Tires.Queries.GetTiresByPrice;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByRing
{
    public class GetTiresByRingQueryValidator : AbstractValidator<GetTiresByRingQuery>
    {
        public GetTiresByRingQueryValidator()
        {
            RuleFor(x => x.Ring).NotEmpty().GreaterThan(10);
        }
    }
}
