using Finance.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}
