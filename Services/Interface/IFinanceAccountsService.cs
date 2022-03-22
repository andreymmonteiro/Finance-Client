using Financial.Application.Protos;
using System.Threading.Tasks;

namespace Financial_Client.Services.Interface
{
    public interface IFinanceAccountsService
    {
        Task<object> GetAllAsync();
        Task<object> CreateAsync(FinanceAccountsCreateRequest request);
    }
}
