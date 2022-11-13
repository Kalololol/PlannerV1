using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetPlanDayByIdQueryHandler : IRequestHandler<GetPlanDayByIdQuery, PlanDayViewModel>
    {
        private readonly IRepository<PlanDay> _planDayRepository;
        private readonly IMapper _mapper;

        public GetPlanDayByIdQueryHandler(IRepository<PlanDay> planDayRepository, IMapper mapper)
        {
            _planDayRepository = planDayRepository;
            _mapper = mapper;
        }

        public async Task<PlanDayViewModel> Handle(GetPlanDayByIdQuery request, CancellationToken cancellationToken)
        {
            var planDay = _planDayRepository.GetById(request.Id);
            var result = _mapper.Map<PlanDayViewModel>(planDay);

            return result;
        }
    }
}
