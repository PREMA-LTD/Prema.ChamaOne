using Prema.ChamaOne.Api.Backend.Models.BaseTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prema.ChamaOne.Api.Backend.Models.Location
{
    [Table("county")]
    public class County : BaseType
    {

        public ICollection<Subcounty> Subcounties { get; set; }
    }
}
