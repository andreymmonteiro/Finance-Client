using System;
using System.Collections.Generic;

namespace Financial.Domain.Dtos.FinanceAccounts.Items
{
    public class FinanceAccountsItemsDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public Guid FinanceAccountId { get; set; }

        public FinanceAccountsDto FinanceAccount { get; set; }

        public IEnumerable<FinanceAccountsPaymentItemsDto> PaymentItems { get; set; }

        public decimal GrossTotal { get; set; }

        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        public decimal Addition { get; set; }

        public DateTime DueDate { get; set; }
    }
}
