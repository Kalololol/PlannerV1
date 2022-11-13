using AutoMapper;
using MediatR;
using Planner.Application.ViewModels;
using Planner.Data.Repositories;
using Planner.Domain.Entities;

namespace Planner.Application.Service.Queries
{
    public class GetContractsQueryHandler : IRequestHandler<GetContractsQuery, List<ContractViewModel>>
    {
        private readonly IRepository<Contract> _contractRepository;
        private readonly IMapper _mapper;

        public async Task<List<ContractViewModel>> Handle(GetContractsQuery request, CancellationToken cancellationToken)
        {
            var contracts = _contractRepository.GetAll();
            List<ContractViewModel> result = new List<ContractViewModel>();

            foreach(var i in contracts)
            {
                var contract = _mapper.Map<ContractViewModel>(i);
                result.Add(contract);
            }


            return result;
        }
    }
}
