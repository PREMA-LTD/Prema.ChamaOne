using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("loan")]
    public class Loan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public decimal principal { get; set; }
        public decimal interest_rate { get; set; }
        public decimal interest { get; set; }
        public decimal penalty { get; set; }


        [Required]
        public int fk_member_id { get; set; }
        [ForeignKey("fk_member_id")]
        public Member Member { get; set; }

        [Required]
        public int fk_transaction_id { get; set; }
        [ForeignKey("fk_transaction_id")]
        public Transaction Transaction { get; set; }
    }

    public class LoanDto
    {
        public int id { get; set; }
        public decimal principal { get; set; }
        public decimal interest_rate { get; set; }
        public decimal interest { get; set; }
        public decimal penalty { get; set; }
        public int fk_member_id { get; set; }
        public int fk_transaction_id { get; set; }
    }
}
