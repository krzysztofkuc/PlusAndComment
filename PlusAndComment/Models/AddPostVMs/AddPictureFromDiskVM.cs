using PlusAndComment.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace PlusAndComment.Models.AddPostVMs
{
    [Serializable]
    public class AddPictureFromDiskVM : PostVM
    {
        [Display(Name = "Opis")]
        public string Header { get; set; }

        public Picture Picture { get; set; }

        public Gif Gif { get; set; }
    }
}