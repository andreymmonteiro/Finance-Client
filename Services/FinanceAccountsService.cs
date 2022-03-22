using Financial.Application.Protos;
using Financial_Client.Services.Interface;
using System.Threading.Tasks;

namespace Financial_Client.Services
{
    public class FinanceAccountsService : IFinanceAccountsService
    {
        private readonly Finance.FinanceClient _financeClient;

        public FinanceAccountsService(Finance.FinanceClient financeBase)
        {
            _financeClient = financeBase;
        }

        public async Task<object> GetAllAsync()
        {
            return await _financeClient.GetAllFinanceAccountsAsync(new FinanceAccountsRequest());
        }

        public async Task<object> CreateAsync(FinanceAccountsCreateRequest request) 
        {
            return await _financeClient.CreateFinanceAccountsAsync(request);
        }
    }
}
