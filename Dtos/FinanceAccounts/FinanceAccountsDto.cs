using Financial.Domain.Dtos.FinanceAccounts.Items;
using Financial.Domain.Models.ModelTypes;
using System;
using System.Collections.Generic;

namespace Financial.Domain.Dtos.FinanceAccounts
{
    public class FinanceAccountsDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public FinanceAccountType FinanceAccountType { get; set; }

        public Guid PaymentTermsId { get; set; }

        public IEnumerable<FinanceAccountsItemsDto> FinanceAccountsItems { get; set; }

        public Guid PersonId { get; set; }
    }
}
