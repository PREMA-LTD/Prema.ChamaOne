using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("contribution_status")]
    public class ContributionStatus : BaseType
    {
        public ICollection<Contribution> Contributions { get; set; }
    }

    public class ContributionStatusDto : BaseType
    {

    }
}
