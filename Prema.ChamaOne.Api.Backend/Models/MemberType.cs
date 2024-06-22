using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
{

    [Table("member_type")]
    public class MemberType : BaseType
    {
        public ICollection<Member> Members { get; set; }
    }

    public class MemberTypeDto : BaseType
    {

    }
}
