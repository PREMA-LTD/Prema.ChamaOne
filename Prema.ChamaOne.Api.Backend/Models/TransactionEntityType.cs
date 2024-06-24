using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
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
