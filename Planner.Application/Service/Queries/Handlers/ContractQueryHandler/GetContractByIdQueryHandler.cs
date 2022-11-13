using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetContractByIdQueryHandler : IRequestHandler<GetContractByIdQuery, ContractViewModel>
    {

        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public GetContractByIdQueryHandler(IRepository<Contract> contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task<ContractViewModel> Handle(GetContractByIdQuery request, CancellationToken cancellationToken)
        {
            var contract = _contractRepository.GetById(request.Id);
            var result = _mapper.Map<ContractViewModel>(contract);

            return result;
        }
    }
}
