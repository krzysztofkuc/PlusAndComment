﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PlusAndComment.Models
{
    public class ArticleVM
    {
        public int Id { get; set; }
        [Url]
        [Required]
        public string Url { get; set; }
        [Required]
        [Display(Name = "Tytuł")]
        public string Header { get; set; }
        [Required]
        [Display(Name = "Krótki opis")]
        public string ShortDesc { get; set; }
        [Required]
        [Display(Name = "Treść")]
        public string LongDesc { get; set; }
        [Display(Name = "Ścieżka do pliku")]
        public string AbstThumbPath { get; set; }
        [Required]
        public string RelThumbPath { get; set; }
        public DateTime? AddedTime { get; set; }
    }
}