using System.ComponentModel;

namespace PlusAndComment.Models
{
    public class PostDetailsVM
    {
        public int ParentPostID { get; set; }
        public int ID { get; set; }
        public string Header { get; set; }
        public string Url { get; set; }
        [DisplayName("Krótki opis")]
        public string ShortDescription { get; set; }
        public string FilePath { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [DisplayName("18+")]
        public bool NeedAge { get; set; }
    }
}