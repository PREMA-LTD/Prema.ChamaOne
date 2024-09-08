using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("transaction_entity")]
    public class TransactionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int? fk_contribution_id { get; set; } = null;
        [ForeignKey("fk_contribution_id")]
        public Contribution? Contribution { get; set; }

        [Required]
        public int? fk_loan_id { get; set; } = null;
        [ForeignKey("fk_loan_id")]
        public Loan? Loan { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }
}
