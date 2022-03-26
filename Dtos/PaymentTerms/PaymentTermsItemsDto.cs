using System;

namespace Financial.Domain.Dtos.PaymentTerms
{
    public class PaymentTermsItemsDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public int Days { get; set; }

        public decimal Addition { get; set; }

        public decimal Discount { get; set; }

        public Guid PaymentTermsId { get; set; }

        public PaymentTermsDto PaymentTerms { get; set; }
    }
}
