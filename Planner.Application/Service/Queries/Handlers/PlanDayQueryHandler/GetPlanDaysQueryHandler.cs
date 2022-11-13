using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetPlanDaysQueryHandler : IRequestHandler<GetPlanDaysQuery, List<PlanDayViewModel>>
    {
        private readonly IRepository<PlanDay> _planDayRepository;
        private readonly IMapper _mapper;

        public GetPlanDaysQueryHandler(IRepository<PlanDay> planDayRepository, IMapper mapper)
        {
            _planDayRepository = planDayRepository;
            _mapper = mapper;
        }

        public async Task<List<PlanDayViewModel>> Handle(GetPlanDaysQuery request, CancellationToken cancellationToken)
        {
            var planDays = _planDayRepository.GetAll();
            List<PlanDayViewModel> result = new List<PlanDayViewModel>();

            foreach (var i in planDays)
            {
                var planDay = _mapper.Map<PlanDayViewModel>(i);
                result.Add(planDay);
            }

            return result;
        }
    }
}
