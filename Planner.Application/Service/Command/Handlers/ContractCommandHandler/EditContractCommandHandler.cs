using AutoMapper;
using MediatR;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Command
{
    public class EditContractCommandHandler : IRequestHandler<EditContractCommand, Unit>
    {
        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public EditContractCommandHandler(IRepository<Contract> contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(EditContractCommand request, CancellationToken cancellationToken)
        {
            var contract = _contractRepository.GetById(request.Id);

            if(contract != null)
            {
                contract.DeclaredHours = request.DeclaredHours;
                contract.ContractType = (ContractType)request.ContractType;
                contract.EmployeeId = request.EmployeeId;
            }

            _contractRepository.Update(contract);

            return Task.FromResult(Unit.Value);
        }
    }
}
