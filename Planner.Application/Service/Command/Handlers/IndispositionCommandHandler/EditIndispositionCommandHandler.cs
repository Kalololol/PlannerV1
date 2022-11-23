using AutoMapper;
using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class EditIndispositionCommandHandler : IRequestHandler<EditIndispositionCommand, Unit>
    {
        private readonly IRepository<Indisposition> _indispositionRequest;
        private readonly IMapper _mapper;

        public EditIndispositionCommandHandler(IRepository<Indisposition> indispositionRequest, IMapper mapper)
        {
            _indispositionRequest = indispositionRequest;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditIndispositionCommand request, CancellationToken cancellationToken)
        {
            var indisposition = _indispositionRequest.GetById(request.Id);

            if(indisposition != null)
            {
              //  indisposition.Change = request.Change;
                indisposition.DayIndisposition = request.DayIndisposition;
            }
            
            throw new NotImplementedException();
        }
    }
}
