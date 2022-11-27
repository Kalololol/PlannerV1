using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class CreateIndispositionCommandHandler : IRequestHandler<CreateIndispositionCommand, Unit>
    {
        private readonly IRepository<Indisposition> _indispositionRepository;
        private readonly IMapper _mapper;

        public CreateIndispositionCommandHandler(IRepository<Indisposition> indispositionRepository, IMapper mapper)
        {
            _indispositionRepository = indispositionRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(CreateIndispositionCommand request, CancellationToken cancellationToken)
        {
            //var indisposition = new CreateIndispositionCommand()
            var indisposition = new IndispositionViewModel()
            {
                DayIndisposition = request.DayIndisposition,
                Change = request.Change,
                EmployeeId = request.EmployeeId
            };
            var result = _mapper.Map<Indisposition>(indisposition);
            _indispositionRepository.Add(result);

            return Task.FromResult(Unit.Value);

        }
    }
}
