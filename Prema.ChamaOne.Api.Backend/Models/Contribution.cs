using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Prema.ChamaOne.Api.Backend.Models.Location;

namespace Prema.ChamaOne.Api.Backend.Models
{
    public class Contribution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public decimal amount { get; set; }
        public decimal penalty { get; set; }

        [Required]
        public int fk_member_id { get; set; }
        [ForeignKey("fk_member_id")]
        public Member Member { get; set; }

        [Required]
        public int fk_contribution_status_id { get; set; }
        [ForeignKey("fk_contribution_status_id")]
        public ContributionStatus ContributionStatus { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
    
    public class ContributionDto
    {
        public int id { get; set; }
        public decimal amount { get; set; }
        public decimal penalty { get; set; }
        public int fk_contribution_status_id { get; set; }
        public int fk_member_id { get; set; }

    }
}
