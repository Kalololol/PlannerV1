using AutoMapper;
using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, Unit>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public CreateRequestCommandHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {
            var req = new CreateRequestCommand()
            {
                DayRequest = request.DayRequest,
                Change = request.Change,
                EmployeeId = request.EmployeeId
            };
            var result = _mapper.Map<Request>(req);
            _requestRepository.Add(result);

            return Task.FromResult(Unit.Value);
        }
    }
}
