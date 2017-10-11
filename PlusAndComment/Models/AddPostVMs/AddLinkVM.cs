using PlusAndComment.Common;
using System;
using System.ComponentModel.DataAnnotations;
using static PlusAndComment.Common.Enums;

namespace PlusAndComment.Models.AddPostVMs
{
    [Serializable]
    public class AddLinkVM : PostVM
    {
        //[Display(Name = "Url obrazka")]
        //[Url]
        //public string ImageUrl { get; set; }

        //[Display(Name = "Ścieżka względna obrazka")]
        //public string ImageRelativePath { get; set; }

        //[Display(Name = "Ścieżka bezwzględna obrazka")]
        //public string ImageAbsolutePath { get; set; }

        public Picture Picture { get; set; }

        public Gif Gif { get; set; }

        [Url]
        public string Url { get; set; }

        [Url]
        public string EmbedUrl { get; set; }

        [Display(Name = "Adres URL linku")]
        public string ReferenceUrl { get; set; }

        public string Header { get; set; }
    }
}