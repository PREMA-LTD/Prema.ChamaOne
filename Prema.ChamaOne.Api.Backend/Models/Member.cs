using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Prema.ChamaOne.Api.Backend.Models.Location;

namespace Prema.ChamaOne.Api.Backend.Models
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string surname { get; set; }
        public string other_names { get; set; }
        public DateTime date_of_birth { get; set; }
        public string national_id_number { get; set; }


        [Required]
        public int fk_residence_location_id { get; set; }
        [ForeignKey("fk_residence_location_id")]
        public Ward Ward { get; set; }


        [Required]
        public int fk_gender_id { get; set; }
        [ForeignKey("fk_gender_id")]
        public Gender Gender { get; set; }


        [Required]
        public int fk_member_type_id { get; set; }
        [ForeignKey("fk_member_type_id")]
        public MemberType MemberTypes { get; set; }


        public ICollection<Contribution> Contributions { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
    public class MemberDto
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string other_names { get; set; }
        public DateTime date_of_birth { get; set; }
        public string national_id_number { get; set; }
        public int fk_residence_location_id { get; set; }
        public int fk_gender_id { get; set; }
        public int fk_member_type_id { get; set; }
    }
}
