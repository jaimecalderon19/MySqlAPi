using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MySqlAPi.Models
{
    public class TaskAssignment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("TaskId")]
        public int TaskId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Required]
        public DateTime AssignedDate { get; set; }

        [ValidateNever]
        public virtual Task Task { get; set; }

        [ValidateNever]
        public virtual User User { get; set; }
    }
}

