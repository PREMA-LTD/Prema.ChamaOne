using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace Prema.ChamaOne.Api.Backend.Models.BaseTypes
{
    public class AuditBaseType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public OperationType operation_type { get; set; }
        public string changed_by { get; set; }
        public DateTime changed_at { get; set; }
        public JsonObject original_data { get; set; }
        public JsonObject new_data { get; set; }
    }

    public enum OperationType
    {
        INSERT,
        UPDATE,
        DELETE
    }
}
