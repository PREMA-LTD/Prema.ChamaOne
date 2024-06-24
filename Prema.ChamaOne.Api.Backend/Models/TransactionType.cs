using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
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
