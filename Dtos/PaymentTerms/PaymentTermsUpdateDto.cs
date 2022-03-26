using System;
using System.Collections.Generic;

namespace Financial.Domain.Dtos.PaymentTerms
{
    public class PaymentTermsUpdateDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime UpdateAt { get; set; }

        public string Description { get; set; }

        public int ForceExpiration { get; set; }

        public IEnumerable<PaymentTermsItemsDto> PaymentTermsItems { get; set; }
    }
}
