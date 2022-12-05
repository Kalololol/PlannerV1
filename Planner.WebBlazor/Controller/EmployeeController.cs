﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<IEnumerable<AllEmployee>>> GetAll()
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

        [HttpGet("{id}")]
        [Route("getEmployeeById")]
        public async Task<ActionResult<IEnumerable<AllEmployee>>> GetEmployeeById(int id)
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

            }catch (Exception )
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Brak użtkownika o podanym identyfikatorze");
               // return BadRequest();

            }


            // return Ok();
        }

        
    }
}