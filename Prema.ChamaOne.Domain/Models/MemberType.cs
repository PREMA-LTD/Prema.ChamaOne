using Prema.ChamaOne.Domain.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Domain.Models
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
