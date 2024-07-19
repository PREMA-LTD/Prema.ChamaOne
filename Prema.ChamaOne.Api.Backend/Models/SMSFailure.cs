using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Prema.ChamaOne.Api.Backend.Models.Location;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("sms_failure")]
    public class SMSFailure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string error { get; set; }
        public DateTime date_time { get; set; }


        [Required]
        public int fk_sms_record_id { get; set; }
        [ForeignKey("fk_sms_record_id")]
        public SMSRecord SMSRecord { get; set; }
    }
}
