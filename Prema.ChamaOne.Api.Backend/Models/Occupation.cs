using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
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
