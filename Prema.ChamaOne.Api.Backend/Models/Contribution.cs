using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Prema.ChamaOne.Api.Backend.Models.Location;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("contribution")]
    public class Contribution : TransactionEntity
    {
        [Column(TypeName = "decimal(14,2)")]
        public decimal amount { get; set; }
        [Column(TypeName = "decimal(14,2)")]
        public decimal balance { get; set; }
        [Column(TypeName = "decimal(14,2)")]
        public decimal penalty { get; set; }
        public DateOnly contribution_period { get; set; }

        [Required]
        public int fk_member_id { get; set; }
        [ForeignKey("fk_member_id")]
        public Member Member { get; set; }


        [Required]
        public TransactionStatusEnum fk_transaction_status_id { get; set; }
        [ForeignKey("fk_transaction_status_id")]
        public TransactionStatus TransactionStatus { get; set; }


    }
    
    public class ContributionDto
    {
        public int id { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }
        public decimal penalty { get; set; }
        public DateOnly contribution_period { get; set; }
        public int fk_transaction_status_id { get; set; }
        public int fk_member_id { get; set; }

    }

    public class ContributionDetails
    {
        public decimal amount_paid { get; set; }
        public string reference { get; set; }
        public DateTime date_of_payment { get; set; }
        public DateOnly contribution_period { get; set; }
        public int member_id { get; set; }

    }
}
