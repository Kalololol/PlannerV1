using AutoMapper;
using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class DeleteIndispositionCommandHandler : IRequestHandler<DeleteIndispositionCommand, Unit>
    {
        private readonly IRepository<Indisposition> _indispositionRepository;
        private readonly IMapper _mapper;

        public DeleteIndispositionCommandHandler(IRepository<Indisposition> indispositionRepository, IMapper mapper)
        {
            _indispositionRepository = indispositionRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(DeleteIndispositionCommand request, CancellationToken cancellationToken)
        {
            var indisposition = _indispositionRepository.GetById(request.Id);

            if(indisposition != null)
            {
                _indispositionRepository.Delete(indisposition);
            }

            return Task.FromResult(Unit.Value);
        }
    }
}
