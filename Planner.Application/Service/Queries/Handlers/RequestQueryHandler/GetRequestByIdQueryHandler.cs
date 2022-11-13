using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetRequestByIdQueryHandler : IRequestHandler<GetRequestByIdQuery, RequestViewModel>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public GetRequestByIdQueryHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public async Task<RequestViewModel> Handle(GetRequestByIdQuery request, CancellationToken cancellationToken)
        {
            var req = _requestRepository.GetById(request.Id);
            var result = _mapper.Map<RequestViewModel>(req);

            return result;
        }
    }
}
