using Financial.Application.Protos;
using Financial_Client.Services.Interface;
using System;
using System.Threading.Tasks;

namespace Financial_Client.Services
{
    public class PaymentTermsService : IPaymentTermsService
    {
        private readonly PaymentTermsProtoService.PaymentTermsProtoServiceClient _service;

        public PaymentTermsService(PaymentTermsProtoService.PaymentTermsProtoServiceClient service)
        {
            _service = service;
        }

        public async Task<PaymentTermsProtoDto> Get(Guid id)
        {
            return await _service.GetAsync(new PaymentTermsSingleRequest() { Id = id.ToString()});
        }
    }
}
