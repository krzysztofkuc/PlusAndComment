using System;
using static PlusAndComment.Common.Enums;

namespace PlusAndComment.Models
{
    [Serializable]
    public class AddPostVM : PostDetailsVM
    { 
        public PostType Type { get; set; }
        public string ImageUrl { get; set; }
        public string EmbedUrl { get; set; }
        public string ReferenceUrl { get; set; }
        public string Content { get; set; }
    }
}