using Application.Tires.Queries.GetTire;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresByBrand
{
    public class GetTiresByBrandQueryValidator: AbstractValidator<GetTiresByBrandQuery>
    {
        public GetTiresByBrandQueryValidator()
        {
            RuleFor(x => x.Brand).NotEmpty().MinimumLength(3);
        }
    }
}
