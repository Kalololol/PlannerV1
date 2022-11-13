using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetPlanMonthByIdQueryHandler : IRequestHandler<GetPlanMonthByIdQuery, PlanMonthViewModel>
    {
        private readonly IRepository<PlanMonth> _planMonthRepository;
        private readonly IMapper _mapper;

        public GetPlanMonthByIdQueryHandler(IRepository<PlanMonth> planMonthRepository, IMapper mapper)
        {
            _planMonthRepository = planMonthRepository;
            _mapper = mapper;
        }

        public async Task<PlanMonthViewModel> Handle(GetPlanMonthByIdQuery request, CancellationToken cancellationToken)
        {
            var planMonth = _planMonthRepository.GetById(request.Id);
            var result = _mapper.Map<PlanMonthViewModel>(planMonth);

            return result;
        }
    }
}
