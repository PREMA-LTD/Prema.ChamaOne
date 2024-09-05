using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("loan")]
    public class Loan : TransactionEntity
    {
        [Column(TypeName = "decimal(14,2)")]
        public decimal principal { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal interest_rate { get; set; }
        [Column(TypeName = "decimal(14,2)")]
        public decimal interest { get; set; }
        [Column(TypeName = "decimal(14,2)")]
        public decimal penalty { get; set; }
        public DateTime date_due { get; set; }

        [Required]
        public int fk_member_id { get; set; }
        [ForeignKey("fk_member_id")]
        public Member Member { get; set; }


        [Required]
        public TransactionStatusEnum fk_transaction_status_id { get; set; }
        [ForeignKey("fk_transaction_status_id")]
        public TransactionStatus TransactionStatus { get; set; }


    }

    public class LoanDto
    {
        public int id { get; set; }
        public decimal principal { get; set; }
        public decimal interest_rate { get; set; }
        public decimal interest { get; set; }
        public decimal penalty { get; set; }
        public int fk_member_id { get; set; }
    }
}
