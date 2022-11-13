using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries.Handlers.PlanMonthQueryHandler
{
    public class GetPlanMonthsQueryHandler : IRequestHandler<GetPlanMonthsQuery, List<PlanMonthViewModel>>
    {
        private readonly IRepository<PlanMonth> _planMonthRepository;
        private readonly IMapper _mapper;

        public GetPlanMonthsQueryHandler(IRepository<PlanMonth> planMonthRepository, IMapper mapper)
        {
            _planMonthRepository = planMonthRepository;
            _mapper = mapper;
        }

        public async Task<List<PlanMonthViewModel>> Handle(GetPlanMonthsQuery request, CancellationToken cancellationToken)
        {
            var planMonths = _planMonthRepository.GetAll();
            List<PlanMonthViewModel> result = new List<PlanMonthViewModel>();

            foreach(var i in planMonths)
            {
                var planMonth = _mapper.Map<PlanMonthViewModel>(i);
                result.Add(planMonth);
            }

            return result;
        }
    }
}
