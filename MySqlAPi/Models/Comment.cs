using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySqlAPi.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TaskId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string CommentText { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        [ValidateNever]
        public virtual Task Task { get; set; }
        [ValidateNever]
        public virtual User User { get; set; }
    }
}