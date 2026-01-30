using Prema.ChamaOne.Domain.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Domain.Models
{

    [Table("transaction_entity_type")]
    public class TransactionEntityType : BaseType
    {
        public ICollection<Transaction> Transactions { get; set; }
    }

    public class TransactionEntityTypeDto : BaseType
    {

    }
}
