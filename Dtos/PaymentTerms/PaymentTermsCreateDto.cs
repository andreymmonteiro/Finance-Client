using System;
using System.Collections.Generic;

namespace Financial.Domain.Dtos.PaymentTerms
{
    public class PaymentTermsCreateDto
    {

        public Guid CompanyId { get; set; }

        public DateTime CreateAt { get; set; }

        public string Description { get; set; }

        public int ForceExpiration { get; set; }

        public IEnumerable<PaymentTermsItemsDto> PaymentTermsItems { get; set; }
    }
}
