using Prema.ChamaOne.Domain.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Domain.Models
{

    [Table("occupation")]
    public class Occupation : BaseType
    {
        public ICollection<Member> Members { get; set; }
    }

    public class OccupationDto : BaseType
    {

    }
}
