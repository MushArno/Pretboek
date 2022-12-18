using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pretboek.Models
{
    public class Comment
    {
        [Key]
        
        public int comment_id { get; set; }

        [Display(Name = "Author")]
        public int author_id { get; set; }
        [Display(Name = "Comment")]
        public string comment_text { get; set;}
    }
}
