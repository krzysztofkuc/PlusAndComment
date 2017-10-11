using System;

namespace PlusAndComment.Models.AddPostVMs
{
    [Serializable]
    public class AddHumourVM : PostVM
    {
        public string Content { get; set; }
    }
}