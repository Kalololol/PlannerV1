using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetWardByIdQueryHandler : IRequestHandler<GetWardByIdQuery, WardViewModel>
    {
        private readonly IRepository<Ward> _wardRepository;
        private readonly IMapper _mapper;

        public GetWardByIdQueryHandler(IRepository<Ward> wardRepository, IMapper mapper)
        {
            _wardRepository = wardRepository;
            _mapper = mapper;
        }

        public async Task<WardViewModel> Handle(GetWardByIdQuery request, CancellationToken cancellationToken)
        {
            var ward = _wardRepository.GetById(request.Id);
            var result = _mapper.Map<WardViewModel>(ward);

            return result;
        }
    }
}
