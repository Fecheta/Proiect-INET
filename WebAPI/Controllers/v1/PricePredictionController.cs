using Application.Features.Processing;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    public class PricePredictionController : BaseController
    {
        public PricePredictionController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Predict()
        {
            return Ok(await mediator.Send(new PredictPriceProccess()));
        }

    }
}
