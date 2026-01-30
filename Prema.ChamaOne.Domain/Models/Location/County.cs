using Prema.ChamaOne.Domain.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Domain.Models.Location
{
    [Table("county")]
    public class County : BaseType
    {

        public ICollection<Subcounty> Subcounties { get; set; }
    }

    public class CountyDto : BaseType
    {
    }
}
