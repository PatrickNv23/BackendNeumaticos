using Application.Tires.Queries.GetTire;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByPrice
{
    public class GetTiresByPriceQueryValidator : AbstractValidator<GetTiresByPriceQuery>
    {
        public GetTiresByPriceQueryValidator()
        {
            RuleFor(x => x.OptionPrice).NotEmpty();
        }
    }
}
