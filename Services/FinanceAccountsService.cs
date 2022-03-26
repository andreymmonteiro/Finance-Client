using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial_Client.Mapper.Interface;
using Financial_Client.Services.Interface;
using System;
using System.Threading.Tasks;

namespace Financial_Client.Services
{
    public class FinanceAccountsService : IFinanceAccountsService
    {
        private readonly FinanceAccountsProtoService.FinanceAccountsProtoServiceClient _financeClient;

        public FinanceAccountsService(FinanceAccountsProtoService.FinanceAccountsProtoServiceClient financeBase)
        {
            _financeClient = financeBase;
        }

        public async Task<ListFinanceAccountsProtoDto> GetAllAsync()
        {
            return await _financeClient.GetAllFinanceAccountsAsync(new FinanceAccountsRequest());
        }

        public async Task<FinanceAccountsProtoDto> CreateAsync(FinanceAccountsCreateRequest request)
        {
            return await _financeClient.CreateFinanceAccountsAsync(request);
        }

        public async Task<FinanceAccountsProtoDto> GetAsync(FinanceAccountsSingleRequest request)
        {
            return await _financeClient.GetFinanceAccountsAsync(request);
        }

        public async Task<FinanceAccountsProtoDto> UpdateAsync(FinanceAccountsUpdateRequest request)
        {
            return await _financeClient.UpdateFinanceAccountsAsync(request);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
