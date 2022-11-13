using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetIndispositionsQueryHandler : IRequestHandler<GetIndispositionsQuery, List<IndispositionViewModel>>
    {
        private readonly IRepository<Indisposition> _indispositionRepository;
        private readonly IMapper _mapper;

        public GetIndispositionsQueryHandler(IRepository<Indisposition> indispositionRepository, IMapper mapper)
        {
            _indispositionRepository = indispositionRepository;
            _mapper = mapper;
        }

        public async Task<List<IndispositionViewModel>> Handle(GetIndispositionsQuery request, CancellationToken cancellationToken)
        {
            var indispositions = _indispositionRepository.GetAll();
            List<IndispositionViewModel> result = new List<IndispositionViewModel>();

            foreach(var i in indispositions)
            {
                var indisposition = _mapper.Map<IndispositionViewModel>(i);
                result.Add(indisposition);
            }

            return result;
        }
    }
}
