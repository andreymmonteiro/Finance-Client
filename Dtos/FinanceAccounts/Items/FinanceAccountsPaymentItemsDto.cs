using System;

namespace Financial.Domain.Dtos.FinanceAccounts.Items
{
    public class FinanceAccountsPaymentItemsDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public Guid FinanceAccountsItemsId { get; set; }

        public FinanceAccountsItemsDto FinanceAccountsItems { get; set; }

        public DateTime Payday { get; set; }

        public decimal Total { get; set; }
    }
}
