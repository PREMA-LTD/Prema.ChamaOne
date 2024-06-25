using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("transaction_status")]
    public class TransactionStatus : BaseType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TransactionStatusEnum id { get; set; }
        public ICollection<Contribution> Contributions { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }

    public class TransactionStatusDto : BaseType
    {

    }

    public enum TransactionStatusEnum
    {
        Paid = 1,
        Pending = 2,
        Overdue = 3
    }
}
