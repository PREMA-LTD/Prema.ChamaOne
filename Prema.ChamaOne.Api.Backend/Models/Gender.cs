using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace Prema.ChamaOne.Api.Backend.Models
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
