using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planner.Application.Service.Command;
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
        [HttpGet("{id:int}")]
        [Route("getIndispositionById/{id}")]
        public async Task<ActionResult<EditIndisposition>> GetIndispositionById(int id)
        {
            try
            {
                var item = await _mediator.Send(new GetIndispositionByIdQuery(id));

                if (item == null) return NotFound();
                else
                {
                    var result = _mapper.Map<EditIndisposition>(item);
                    return Ok(result);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak użtkownika o podanym identyfikatorze");
            }
        }
        [HttpPost]
        [Route("createIndisposition")]
        public async Task<ActionResult<CreateIndisposition>> CreateIndisposition(CreateIndisposition indisposition)
        {
            try
            {
                if (indisposition == null)
                    return BadRequest();

                await _mediator.Send(_mapper.Map<CreateIndispositionCommand>(indisposition));

                return Ok("Dodano");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
        [HttpPost]
        [Route("editIndisposition")]
        public async Task<ActionResult<EditIndisposition>> EditIndisposition(EditIndisposition indisposition)
        {
            try
            {
                if (indisposition == null)
                    return BadRequest();
                await _mediator.Send(_mapper.Map<EditIndispositionCommand>(indisposition));

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

    }
}
