using Application.Tires.Queries.GetTire;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tires.Queries.GetTiresById
{
    public class GetTiresByIdQueryValidator : AbstractValidator<GetTiresByIdQuery>
    {
        public GetTiresByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
