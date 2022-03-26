using Financial.Application.Protos;
using System;
using System.Threading.Tasks;

namespace Financial_Client.Services.Interface
{
    public interface IFinanceAccountsService
    {
        Task<ListFinanceAccountsProtoDto> GetAllAsync();

        Task<FinanceAccountsProtoDto> CreateAsync(FinanceAccountsCreateRequest request);

        Task<FinanceAccountsProtoDto> GetAsync(FinanceAccountsSingleRequest request);

        Task<FinanceAccountsProtoDto> UpdateAsync(FinanceAccountsUpdateRequest request);

        Task<bool> DeleteAsync(Guid id);
    }
}
