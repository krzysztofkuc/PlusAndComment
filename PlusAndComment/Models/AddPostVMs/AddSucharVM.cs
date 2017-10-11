using System;
using System.ComponentModel.DataAnnotations;

namespace PlusAndComment.Models.AddPostVMs
{
    [Serializable]
    public class AddSucharVM : PostVM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public string AbsThumbPath { get; set; }

        public string RelThumbPath { get; set; }
    }
}