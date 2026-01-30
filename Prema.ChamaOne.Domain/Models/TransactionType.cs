using Prema.ChamaOne.Domain.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Domain.Models
{

    [Table("transaction_type")]
    public class TransactionType : BaseType
    {
        public ICollection<Transaction> Transactions { get; set; }
    }

    public class TransactionTypeDto : BaseType
    {

    }
}
