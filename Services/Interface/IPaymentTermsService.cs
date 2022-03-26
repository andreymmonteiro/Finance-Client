using Financial.Application.Protos;
using System;
using System.Threading.Tasks;

namespace Financial_Client.Services.Interface
{
    public interface IPaymentTermsService
    {
        Task<PaymentTermsProtoDto> Get(Guid id);
    }
}
