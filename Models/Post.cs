using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pretboek.Models
{
    public class Post
    {

        [Key]
        public int post_id { get; set; }
        //[Required]
        [Display(Name = "Title")]
        public string post_title { get; set;}

        [Display(Name = "Image")]
        public string post_img { get; set;}

        [Display(Name = "Author")]
        public string post_author { get; set;}
        public DateTime post_created { get; set; } = DateTime.Now;
        public int post_likes { get; set; } = 0;

    }
}
