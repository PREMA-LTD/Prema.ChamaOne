using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Prema.ChamaOne.Api.Backend.Models.Location;

namespace Prema.ChamaOne.Api.Backend.Models
{
    [Table("sms_record")]
    public class SMSRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string message { get; set; }
        public string recipient_name { get; set; }
        public string recipient_contact { get; set; }
        public DateTime date_time_sent { get; set; }
        public int failure_count { get; set; }
        public sms_status status { get; set; }

        public ICollection<SMSFailure> SMSFailures { get; set; }
    }

    public enum sms_status
    {
        Sent = 1,
        Pending = 2,
        Failed = 3
    }
}
