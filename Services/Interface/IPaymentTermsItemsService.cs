using System;
using System.Threading.Tasks;

namespace Financial_Client.Services.Interface
{
    public interface IPaymentTermsItemsService
    {
        Task<object> Get(Guid id);
    }
}
