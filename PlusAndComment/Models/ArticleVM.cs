using System;

namespace PlusAndComment.Models
{
    public class ArticleVM
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Header { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string AbstThumbPath { get; set; }
        public string RelThumbPath { get; set; }
        public DateTime? AddedTime { get; set; }
    }
}