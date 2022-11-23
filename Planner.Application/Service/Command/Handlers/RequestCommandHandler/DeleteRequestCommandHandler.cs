using AutoMapper;
using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command.Handlers.RequestCommandHandler
{
    public class DeleteRequestCommandHandler : IRequestHandler<DeleteRequestCommand, Unit>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public DeleteRequestCommandHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(DeleteRequestCommand request, CancellationToken cancellationToken)
        {
            var req = _requestRepository.GetById(request.Id);

            if (req != null)
            {
                _requestRepository.Delete(req);
            }

            return Task.FromResult(Unit.Value);
        }
    }
}
