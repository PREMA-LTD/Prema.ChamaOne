using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prema.ChamaOne.Api.Backend.Models.Location
{
    [Table("ward")]
    public class Ward : BaseType
    {

        [Required]
        public int fk_subcounty_id { get; set; }
        [ForeignKey("fk_subcounty_id")]
        public Subcounty Subcounty { get; set; }

        public ICollection<Member> Members { get; set; }
    }

    public class WardDto : BaseType
    {
    }
}
