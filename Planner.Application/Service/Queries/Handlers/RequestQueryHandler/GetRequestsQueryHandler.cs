using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetRequestsQueryHandler : IRequestHandler<GetRequestsQuery, List<RequestViewModel>>
    {
        private readonly IRepository<Request> _requestRepository;
        private readonly IMapper _mapper;

        public GetRequestsQueryHandler(IRepository<Request> requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public async Task<List<RequestViewModel>> Handle(GetRequestsQuery request, CancellationToken cancellationToken)
        {
            var requests = _requestRepository.GetAll();
            List<RequestViewModel> result = new List<RequestViewModel>();

            foreach(var i in requests)
            {
                var req = _mapper.Map<RequestViewModel>(i);
                result.Add(req);
            }

            return result;
        }
    }
}
