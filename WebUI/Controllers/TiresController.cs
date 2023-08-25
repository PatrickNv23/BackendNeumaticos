using Application.Dto;
using Application.Tires.Queries.GetTire;
using Application.Tires.Queries.GetTiresById;
using Application.Tires.Queries.GetTiresByPrice;
using Application.Tires.Queries.GetTiresByRing;
using Application.Tires.Queries.GetTiresByWidth;
using Application.Tires.Queries.ListTires;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class TiresController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TireDto>>> Get([FromQuery] ListTiresQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<TireDto>>> GetById(int id)
        {
            return await Mediator.Send(new GetTiresByIdQuery { Id = id });
        }


        [HttpGet("brand={brand}")]
        public async Task<ActionResult<List<TireDto>>> GetByBrand(string brand)
        {
            return await Mediator.Send(new GetTiresByBrandQuery { Brand = brand });
        }

        [HttpGet("optionPrice={optionPrice}")]
        public async Task<ActionResult<List<TireDto>>> GetByPrice(string optionPrice)
        {
            return await Mediator.Send(new GetTiresByPriceQuery { OptionPrice = optionPrice });
        }

        [HttpGet("ring={ring}")]
        public async Task<ActionResult<List<TireDto>>> GetByRing(int ring)
        {
            return await Mediator.Send(new GetTiresByRingQuery { Ring =  ring });
        }

        [HttpGet("width={width}")]
        public async Task<ActionResult<List<TireDto>>> GetByWidth(int width)
        {
            return await Mediator.Send(new GetTiresByWidthQuery { Witdh = width });
        }
    }
}
