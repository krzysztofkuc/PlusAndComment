using System.Collections.Generic;

namespace PlusAndComment.Models
{
    public class ArticlesVM
    {
        public string Header { get; set; }
        public List<ArticleVM> Articles { get; set; }
    }
}