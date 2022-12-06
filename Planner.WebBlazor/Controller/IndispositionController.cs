using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner.Application.Service.Queries;
using Planner.WebBlazor.Models;

namespace Planner.WebBlazor.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndispositionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public IndispositionController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getAllIndispositions")]
        public async Task<ActionResult<IList<AllIndisposition>>> GetAllIndispositions()
        {

            try
            {
                List<AllIndisposition> result = new List<AllIndisposition>();
                var contracts = await _mediator.Send(new GetIndispositionsQuery());

                if (contracts == null) return NotFound();
                else
                {
                    foreach (var e in contracts)
                    {
                        var contract = _mapper.Map<AllIndisposition>(e);
                        result.Add(contract);
                    }
                    return Ok(result);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak odpowiedzi z bazy, błąd 500");
            }
        }
    }
}
