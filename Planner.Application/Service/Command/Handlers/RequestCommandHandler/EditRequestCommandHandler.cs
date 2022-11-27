using AutoMapper;
using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command.Handlers.RequestCommandHandler
{
    public class EditRequestCommandHandler : IRequestHandler<EditRequestCommand, Unit>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public EditRequestCommandHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditRequestCommand request, CancellationToken cancellationToken)
        {
            var req = _requestRepository.GetById(request.Id);

            if(req != null)
            {
                //req.Change = request.Change;
                req.DayRequest = request.DayRequest;
            }

            _requestRepository.Update(req);

            throw new NotImplementedException();
        }
    }
}
