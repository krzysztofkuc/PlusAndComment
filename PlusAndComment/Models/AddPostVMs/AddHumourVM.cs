using System;
using System.ComponentModel.DataAnnotations;

namespace PlusAndComment.Models.AddPostVMs
{
    [Serializable]
    public class AddHumourVM : PostVM
    {
        [Required]
        public string Content { get; set; }

        public string PostType { get { return "img"; } }
    }
}