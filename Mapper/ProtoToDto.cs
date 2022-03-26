using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial.Domain.Dtos.FinanceAccounts.Items;
using Financial.Domain.Dtos.PaymentTerms;
using System.Collections.Generic;

namespace Financial.Application.Mapper
{
    public class ProtoToDto : Profile
    {
        public ProtoToDto()
        {
            FinanceAccountsDtoToProto();
            PaymentTermsDtoToProto();
        }

        private void FinanceAccountsDtoToProto() 
        {
            CreateMap<FinanceAccountsCreateRequest, FinanceAccountsCreateDto>().ReverseMap();
            CreateMap<FinanceAccountsUpdateRequest, FinanceAccountsUpdateDto>().ReverseMap();
            CreateMap<FinanceAccountsProtoDto, FinanceAccountsDto>().ReverseMap();
            CreateMap<ListFinanceAccountsProtoDto, IEnumerable<FinanceAccountsDto>>().ReverseMap();
            CreateMap<FinanceAccountsItemsRequest, FinanceAccountsItemsDto>().ReverseMap();
        }

        private void PaymentTermsDtoToProto()
        {
            CreateMap<PaymentTermsProtoDto, PaymentTermsDto>();
            CreateMap<PaymentTermsCreate, PaymentTermsCreateDto>();
            CreateMap<PaymentTermsUpdate, PaymentTermsUpdateDto>();
            CreateMap<ListPaymentTermsProtoDto, IEnumerable<FinanceAccountsDto>>().ReverseMap();
            CreateMap<PaymentTermsItemsRequest, PaymentTermsItemsDto>();
        }
    }
}
