using Prema.ChamaOne.Domain.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace Prema.ChamaOne.Domain.Models
{
    [Table("gender")]
    public class Gender : BaseType
    {
        public ICollection<Member> Members { get; set; }
    }

    public class GenderDto : BaseType
    {

    }
}
