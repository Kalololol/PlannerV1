using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetIndispositionByIdQueryHandler : IRequestHandler<GetIndispositionByIdQuery, IndispositionViewModel>
    {
        private readonly IRepository<Indisposition> _indispositionRepository;
        private readonly IMapper _mapper;

        public GetIndispositionByIdQueryHandler(IRepository<Indisposition> indispositionRepository, IMapper mapper)
        {
            _indispositionRepository = indispositionRepository;
            _mapper = mapper;
        }

        public async Task<IndispositionViewModel> Handle(GetIndispositionByIdQuery request, CancellationToken cancellationToken)
        {
            var indisposition = _indispositionRepository.GetById(request.Id);
            var result = _mapper.Map<IndispositionViewModel>(indisposition);

            return result;
        }
    }
}
