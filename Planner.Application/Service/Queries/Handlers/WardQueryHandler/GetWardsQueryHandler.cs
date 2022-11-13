using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetWardsQueryHandler : IRequestHandler<GetWardsQuery, List<WardViewModel>>
    {
        private readonly IRepository<Ward> _wardRepository;
        private readonly IMapper _mapper;

        public GetWardsQueryHandler(IRepository<Ward> wardRepository, IMapper mapper)
        {
            _wardRepository = wardRepository;
            _mapper = mapper;
        }

        public async Task<List<WardViewModel>> Handle(GetWardsQuery request, CancellationToken cancellationToken)
        {
            var wards = _wardRepository.GetAll();
            List<WardViewModel> result = new List<WardViewModel>();

            foreach(var i in wards)
            {
                var ward = _mapper.Map<WardViewModel>(i);
                result.Add(ward);
            }

            return result;
        }
    }
}
