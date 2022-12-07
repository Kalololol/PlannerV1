using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planner.Application.Service.Command;
using Planner.Application.Service.Queries;
using Planner.WebBlazor.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Planner.WebBlazor.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public EmployeeController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<AllEmployee>>> GetAll()
        {

            try
            {
                List<AllEmployee> result = new List<AllEmployee>();
                var employees = await _mediator.Send(new GetEmployeesQuery());

                if (employees == null) return NotFound();
                else
                {
                    foreach (var e in employees)
                    {
                        var employee = _mapper.Map<AllEmployee>(e);
                        result.Add(employee);
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
        [Route("getEmployeeById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<AllEmployee>> GetEmployeeById(int id)
        {
            try
            {
                var item = await _mediator.Send(new GetEmployeeByIdQuery(id));

                if (item == null) return NotFound();
                else
                {
                    var result = _mapper.Map<EditDetailsEmployee>(item);
                    return Ok(result);
                }

            } catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak użtkownika o podanym identyfikatorze");
            }
        }
        [HttpPost]
        [Route("createEmployee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CreateEmployee>> CreateEmployee(CreateEmployee employee)
        {

            try
            {
                if (employee == null)
                    return BadRequest();

                await _mediator.Send(_mapper.Map<CreateEmployeeCommand>(employee));

             //   return CreatedAtAction(nameof(GetEmployeeById),  employee);
                return Ok("Dodano");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPost]
        [Route("editEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<EditDetailsEmployee>> EditEmployee(EditDetailsEmployee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();
                await _mediator.Send(_mapper.Map<EditEmployeeCommand>(employee));

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpDelete("{id:int}")]
        [Route("deleteEmployee")]
        public async Task<ActionResult<EditDetailsEmployee>> DeleteEmployee(EditDetailsEmployee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();
                await _mediator.Send(_mapper.Map<EditEmployeeCommand>(employee));

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
