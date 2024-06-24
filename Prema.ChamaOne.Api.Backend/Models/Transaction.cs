using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Prema.ChamaOne.Api.Backend.Models.Location;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("transaction")]
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime date_of_transaction { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }


        [Required]
        public int fk_transaction_type_id { get; set; }
        [ForeignKey("fk_transaction_type_id")]
        public TransactionType TransactionType { get; set; }

        [Required]
        public int fk_transaction_entity_type_id { get; set; }
        [ForeignKey("fk_transaction_entity_type_id")]
        public TransactionEntityType TransactionEntityType { get; set; }

        [Required]
        public int fk_transaction_entity_id { get; set; }

        public Contribution Contribution { get; set; }
        public Loan Loan { get; set; }

    }


    public class TransactionDto
    {
        public int id { get; set; }
        public DateTime date_of_transaction { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }
        public int fk_contribution_id { get; set; }
    }
}
